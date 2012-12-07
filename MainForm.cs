using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace FogBugzPivot
{
	public partial class MainForm : Form
	{
		private string _token;

		public MainForm()
		{
			InitializeComponent();

			BusyAnimationControl.BaseImage = Properties.Resources.Loading16;

			FacetsListBox.DataSource = FacetCollection.Default;
			FacetsListBox.DisplayMember = "DisplayName";

			for (var i = 0; i < FacetsListBox.Items.Count; i++)
			{
				FacetsListBox.SetItemChecked(i, true);
			}
		}

		private void LogonButtonClick(object sender, EventArgs e)
		{
			SetBusy("Trying to logon...");

			Task.Factory.StartNew(() =>
			{
				var args = new Dictionary<string, string>
				{
					{ "email", UsernameTextBox.Text },
					{ "password", PasswordTextBox.Text },
				};

				return GetCommandResultsAsDocument("logon", args);
			}).ContinueWith(task =>
			{
				SetAvailable();

				if (HasTaskException(task))
				{
					return;
				}

				var document = task.Result;

				if (HasResponseError(document))
				{
					return;
				}

				_token = document.Element("response").Element("token").Value;

				ConnectionGroupBox.Enabled = false;
				GenerationGroupBox.Enabled = true;
				LogoffButton.Enabled = true;

				ListFilters();
			}, TaskScheduler.FromCurrentSynchronizationContext());
		}

		private void LogoffButtonClick(object sender, EventArgs e)
		{
			Logoff();
		}

		private void GenerateButtonClick(object sender, EventArgs e)
		{
			var selectedFilter = FiltersComboBox.SelectedItem as FilterComboItem;

			if (selectedFilter == null)
			{
				return;
			}

			if (string.IsNullOrEmpty(SaveToTextBox.Text))
			{
				SaveToTextBox.Focus();

				return;
			}

			SetBusy("Generating Pivot report...");

			var facets = new FacetCollection();

			foreach (var facet in FacetsListBox.CheckedItems.Cast<Facet>())
			{
				facets.Add(facet);
			}

			if (!Directory.Exists(SaveToTextBox.Text))
			{
				Directory.CreateDirectory(SaveToTextBox.Text);
			}

			CopyDirectory(Path.GetFullPath(".\\pivot_files"), Path.Combine(SaveToTextBox.Text, ".\\pivot_files"));

			var path = Path.Combine(SaveToTextBox.Text, "pivot.cxml");

			Task.Factory.StartNew(() =>
			{
				// You need to set current filter first
				var setFilterDocument = GetCommandResultsAsDocument(
					"setCurrentFilter",
					new Dictionary<string, string> { { "sFilter", selectedFilter.Id } });

				if (HasResponseError(setFilterDocument))
				{
					return;
				}

				var cols = string.Join(",", facets.Select(f => f.Name).Where(f => f != "ixBug"));

				using (var stream = GetCommandResultsAsStream("search", new Dictionary<string, string> { { "cols", cols } }))
				{
					GeneratePivotReport(stream, facets, path, selectedFilter.Name);
				}
			}).ContinueWith(task =>
			{
				SetAvailable();

				if (HasTaskException(task))
				{
					return;
				}

			}, TaskScheduler.FromCurrentSynchronizationContext());
		}

		private void RefreshFiltersButtonClick(object sender, EventArgs e)
		{
			ListFilters();
		}

		private Task Logoff()
		{
			if (string.IsNullOrEmpty(_token))
			{
				return null;
			}

			SetBusy("Trying to logoff...");

			return Task.Factory.StartNew(() => GetCommandResultsAsDocument("logoff")).ContinueWith(task =>
			{
				SetAvailable();

				if (HasTaskException(task))
				{
					return;
				}

				var document = task.Result;

				if (HasResponseError(document))
				{
					return;
				}

				_token = null;

				FiltersComboBox.Items.Clear();
				ConnectionGroupBox.Enabled = true;
				GenerationGroupBox.Enabled = false;
				LogoffButton.Enabled = false;
			}, TaskScheduler.FromCurrentSynchronizationContext());
		}

		private void BrowseSaveToButtonClick(object sender, EventArgs e)
		{
			var dialog = new FolderBrowserDialog
			{
				Description = "Select folder to generate report to",
				SelectedPath = SaveToTextBox.Text,
				ShowNewFolderButton = true,
			};

			var result = dialog.ShowDialog(this);

			if (result == DialogResult.OK)
			{
				SaveToTextBox.Text = dialog.SelectedPath;
			}
		}

		private void MainFormFormClosing(object sender, FormClosingEventArgs e)
		{
			var task = Logoff();

			if (task != null)
			{
				e.Cancel = true;

				task.ContinueWith(t => Close(), TaskScheduler.FromCurrentSynchronizationContext());
			}
		}

		private void SetBusy(string status = "")
		{
			ContainerPanel.Enabled = false;
			UseWaitCursor = true;

			BusyAnimationControl.Visible = true;
			BusyAnimationControl.StartAnimation();

			StatusLabel.Text = status;
		}

		private void SetAvailable()
		{
			ContainerPanel.Enabled = true;
			UseWaitCursor = false;

			BusyAnimationControl.Visible = false;
			BusyAnimationControl.StopAnimation();

			StatusLabel.Text = string.Empty;
		}

		private void ListFilters()
		{
			SetBusy("Fetching filters...");
			FiltersComboBox.Items.Clear();

			Task.Factory.StartNew(() => GetCommandResultsAsDocument("listFilters")).ContinueWith(task =>
			{
				SetAvailable();

				if (HasTaskException(task))
				{
					return;
				}

				var document = task.Result;

				if (HasResponseError(document))
				{
					return;
				}

				var filters = document
					.Element("response")
					.Element("filters")
					.Elements()
					.Select(f => new FilterComboItem(f))
					.ToArray();

				FiltersComboBox.Items.AddRange(filters);

				if (filters.Length > 0)
				{
					FiltersComboBox.SelectedItem = filters[0];
				}
			}, TaskScheduler.FromCurrentSynchronizationContext());
		}

		private bool HasTaskException(Task task)
		{
			if (task.Exception != null)
			{
				MessageBox.Show(
					this,
					"An unexpected error occured:\n\n" + task.Exception,
					"Error",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error);

				return true;
			}

			return false;
		}

		private bool HasResponseError(XDocument document)
		{
			var response = document.Element("response");

			if (response == null)
			{
				MessageBox.Show(this, "No response could be found.", "API Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

				return true;
			}

			var error = response.Element("error");

			if (error != null)
			{
				MessageBox.Show(this, error.Value, "API Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

				return true;
			}

			return false;
		}

		private XDocument GetCommandResultsAsDocument(string command, IDictionary<string, string> args = null)
		{
			var url = GetCommandUrl(command, args);

			return XDocument.Load(url);
		}

		private Stream GetCommandResultsAsStream(string command, IDictionary<string, string> args = null)
		{
			var url = GetCommandUrl(command, args);

			var request = WebRequest.Create(url);

			var response = request.GetResponse();

			return response.GetResponseStream();
		}

		private string GetCommandUrl(string command, IDictionary<string, string> args = null)
		{
			args = args ?? new Dictionary<string, string>();

			if (!string.IsNullOrEmpty(_token))
			{
				args["token"] = _token;				
			}

			var fogBugzUrl = UrlTextBox.Text.EndsWith("/") ? UrlTextBox.Text : UrlTextBox.Text + "/";

			var url = new StringBuilder();

			url.Append(fogBugzUrl);
			url.Append("api.asp?cmd=");
			url.Append(HttpUtility.UrlEncode(command));

			foreach (var arg in args)
			{
				url.Append("&");
				url.Append(HttpUtility.UrlEncode(arg.Key));
				url.Append("=");
				url.Append(HttpUtility.UrlEncode(arg.Value));
			}

			return url.ToString();
		}

		private static void CopyDirectory(string sourcePath, string destinationPath)
		{
			//Now Create all of the directories
			foreach (var dirPath in Directory.GetDirectories(sourcePath, "*", SearchOption.AllDirectories))
			{
				Directory.CreateDirectory(dirPath.Replace(sourcePath, destinationPath));
			}

			//Copy all the files
			foreach (var newPath in Directory.GetFiles(sourcePath, "*.*", SearchOption.AllDirectories))
			{
				File.Copy(newPath, newPath.Replace(sourcePath, destinationPath), true);
			}
		}

		private static void GeneratePivotReport(Stream stream, FacetCollection facets, string path, string collectionName)
		{
			using (var reader = XmlReader.Create(stream))
			using (var writer = new XmlTextWriter(path, Encoding.UTF8))
			{
				reader.Read();
				reader.ReadStartElement("response");
				reader.ReadElementContentAsString("description", string.Empty);

				if ("sFilter".Equals(reader.Name))
				{
					reader.ReadElementContentAsString("sFilter", string.Empty);
				}

				reader.ReadStartElement("cases");

				writer.Formatting = Formatting.Indented;
				writer.WriteStartDocument();
				writer.WriteStartElement("Collection", "http://schemas.microsoft.com/collection/metadata/2009");
				writer.WriteAttributeString("xmlns", "p", null, "http://schemas.microsoft.com/livelabs/pivot/collection/2009");
				writer.WriteAttributeString("SchemaVersion", "1.0");
				writer.WriteAttributeString("Name", collectionName);

				writer.WriteStartElement("FacetCategories");

				foreach (var facet in facets)
				{
					writer.WriteStartElement("FacetCategory");
					writer.WriteAttributeString("Name", facet.DisplayName);
					writer.WriteAttributeString("Type", facet.Type);
					writer.WriteAttributeString("IsFilterVisible", "http://schemas.microsoft.com/livelabs/pivot/collection/2009", facet.IsFilter ? "true" : "false");
					writer.WriteAttributeString("IsWordWheelVisible", "http://schemas.microsoft.com/livelabs/pivot/collection/2009", "true");
					writer.WriteAttributeString("IsMetaDataVisible", "http://schemas.microsoft.com/livelabs/pivot/collection/2009", "true");

					writer.WriteEndElement(); // FacetCategory
				}

				writer.WriteEndElement(); // FacetCategories

				writer.WriteStartElement("Items");

				writer.WriteAttributeString("ImgBase", ".\\pivot_files\\images.xml");

				while (reader.Name == "case")
				{
					var id = reader.GetAttribute("ixBug");

					reader.ReadStartElement("case");

					writer.WriteStartElement("Item");

					writer.WriteAttributeString("Id", id);
					writer.WriteAttributeString("Img", "#0");

					var properties = new Dictionary<string, string>
					{
						{ "ixBug", id },
					};

					while (reader.NodeType != XmlNodeType.EndElement)
					{
						var name = reader.Name;
						var content = reader.ReadElementContentAsString(name, string.Empty);

						properties.Add(name, content);
					}

					if (properties.ContainsKey("sTitle"))
					{
						writer.WriteElementString("Description", properties["sTitle"]);
					}

					writer.WriteStartElement("Facets");

					foreach (var facet in facets)
					{
						facet.WriteTo(writer, properties[facet.Name]);
					}

					writer.WriteEndElement(); // Facets

					writer.WriteEndElement(); // Item

					reader.ReadEndElement(); // case
				}

				writer.WriteEndElement(); // Items

				reader.ReadEndElement(); // cases
				reader.ReadEndElement(); // response
			}
		}
	}
}