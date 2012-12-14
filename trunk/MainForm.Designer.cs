namespace FogBugzPivot
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.LogoffButton = new System.Windows.Forms.Button();
			this.FiltersComboBox = new System.Windows.Forms.ComboBox();
			this.FiltersLabel = new System.Windows.Forms.Label();
			this.GenerateButton = new System.Windows.Forms.Button();
			this.FacetsListBox = new System.Windows.Forms.CheckedListBox();
			this.ConnectionGroupBox = new System.Windows.Forms.GroupBox();
			this.LogonButton = new System.Windows.Forms.Button();
			this.PasswordLabel = new System.Windows.Forms.Label();
			this.PasswordTextBox = new System.Windows.Forms.TextBox();
			this.UsernameLabel = new System.Windows.Forms.Label();
			this.UsernameTextBox = new System.Windows.Forms.TextBox();
			this.UrlLabel = new System.Windows.Forms.Label();
			this.UrlTextBox = new System.Windows.Forms.TextBox();
			this.GenerationGroupBox = new System.Windows.Forms.GroupBox();
			this.BrowseSaveToFolderButton = new System.Windows.Forms.Button();
			this.SaveToTextBox = new System.Windows.Forms.TextBox();
			this.SaveToLabel = new System.Windows.Forms.Label();
			this.RefreshFiltersButton = new System.Windows.Forms.Button();
			this.PropertiesLabel = new System.Windows.Forms.Label();
			this.ContainerPanel = new System.Windows.Forms.Panel();
			this.StatusLabel = new System.Windows.Forms.Label();
			this.BusyAnimationControl = new wyDay.Controls.AnimationControl();
			this.ConnectionGroupBox.SuspendLayout();
			this.GenerationGroupBox.SuspendLayout();
			this.ContainerPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// LogoffButton
			// 
			this.LogoffButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.LogoffButton.Enabled = false;
			this.LogoffButton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.LogoffButton.Location = new System.Drawing.Point(340, 440);
			this.LogoffButton.Name = "LogoffButton";
			this.LogoffButton.Size = new System.Drawing.Size(75, 23);
			this.LogoffButton.TabIndex = 0;
			this.LogoffButton.Text = "L&ogoff";
			this.LogoffButton.UseVisualStyleBackColor = true;
			this.LogoffButton.Click += new System.EventHandler(this.LogoffButtonClick);
			// 
			// FiltersComboBox
			// 
			this.FiltersComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.FiltersComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.FiltersComboBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.FiltersComboBox.FormattingEnabled = true;
			this.FiltersComboBox.Location = new System.Drawing.Point(100, 20);
			this.FiltersComboBox.Name = "FiltersComboBox";
			this.FiltersComboBox.Size = new System.Drawing.Size(274, 21);
			this.FiltersComboBox.TabIndex = 1;
			// 
			// FiltersLabel
			// 
			this.FiltersLabel.AutoSize = true;
			this.FiltersLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.FiltersLabel.Location = new System.Drawing.Point(5, 23);
			this.FiltersLabel.Name = "FiltersLabel";
			this.FiltersLabel.Size = new System.Drawing.Size(45, 13);
			this.FiltersLabel.TabIndex = 0;
			this.FiltersLabel.Text = "Fil&ters:";
			// 
			// GenerateButton
			// 
			this.GenerateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.GenerateButton.Location = new System.Drawing.Point(328, 282);
			this.GenerateButton.Name = "GenerateButton";
			this.GenerateButton.Size = new System.Drawing.Size(75, 23);
			this.GenerateButton.TabIndex = 8;
			this.GenerateButton.Text = "&Generate";
			this.GenerateButton.UseVisualStyleBackColor = true;
			this.GenerateButton.Click += new System.EventHandler(this.GenerateButtonClick);
			// 
			// FacetsListBox
			// 
			this.FacetsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.FacetsListBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.FacetsListBox.Location = new System.Drawing.Point(100, 47);
			this.FacetsListBox.Name = "FacetsListBox";
			this.FacetsListBox.Size = new System.Drawing.Size(303, 196);
			this.FacetsListBox.TabIndex = 4;
			// 
			// ConnectionGroupBox
			// 
			this.ConnectionGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ConnectionGroupBox.Controls.Add(this.LogonButton);
			this.ConnectionGroupBox.Controls.Add(this.PasswordLabel);
			this.ConnectionGroupBox.Controls.Add(this.PasswordTextBox);
			this.ConnectionGroupBox.Controls.Add(this.UsernameLabel);
			this.ConnectionGroupBox.Controls.Add(this.UsernameTextBox);
			this.ConnectionGroupBox.Controls.Add(this.UrlLabel);
			this.ConnectionGroupBox.Controls.Add(this.UrlTextBox);
			this.ConnectionGroupBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.ConnectionGroupBox.Location = new System.Drawing.Point(12, 12);
			this.ConnectionGroupBox.Name = "ConnectionGroupBox";
			this.ConnectionGroupBox.Size = new System.Drawing.Size(413, 103);
			this.ConnectionGroupBox.TabIndex = 0;
			this.ConnectionGroupBox.TabStop = false;
			this.ConnectionGroupBox.Text = "Connection";
			// 
			// LogonButton
			// 
			this.LogonButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.LogonButton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.LogonButton.Location = new System.Drawing.Point(328, 72);
			this.LogonButton.Name = "LogonButton";
			this.LogonButton.Size = new System.Drawing.Size(75, 23);
			this.LogonButton.TabIndex = 6;
			this.LogonButton.Text = "&Logon";
			this.LogonButton.UseVisualStyleBackColor = true;
			this.LogonButton.Click += new System.EventHandler(this.LogonButtonClick);
			// 
			// PasswordLabel
			// 
			this.PasswordLabel.AutoSize = true;
			this.PasswordLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.PasswordLabel.Location = new System.Drawing.Point(5, 77);
			this.PasswordLabel.Name = "PasswordLabel";
			this.PasswordLabel.Size = new System.Drawing.Size(64, 13);
			this.PasswordLabel.TabIndex = 4;
			this.PasswordLabel.Text = "&Password:";
			// 
			// PasswordTextBox
			// 
			this.PasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.PasswordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::FogBugzPivot.Properties.Settings.Default, "Password", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.PasswordTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.PasswordTextBox.Location = new System.Drawing.Point(100, 74);
			this.PasswordTextBox.Name = "PasswordTextBox";
			this.PasswordTextBox.Size = new System.Drawing.Size(222, 21);
			this.PasswordTextBox.TabIndex = 5;
			this.PasswordTextBox.Text = global::FogBugzPivot.Properties.Settings.Default.Password;
			this.PasswordTextBox.UseSystemPasswordChar = true;
			// 
			// UsernameLabel
			// 
			this.UsernameLabel.AutoSize = true;
			this.UsernameLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.UsernameLabel.Location = new System.Drawing.Point(5, 51);
			this.UsernameLabel.Name = "UsernameLabel";
			this.UsernameLabel.Size = new System.Drawing.Size(68, 13);
			this.UsernameLabel.TabIndex = 2;
			this.UsernameLabel.Text = "&Username:";
			// 
			// UsernameTextBox
			// 
			this.UsernameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.UsernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::FogBugzPivot.Properties.Settings.Default, "Username", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.UsernameTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.UsernameTextBox.Location = new System.Drawing.Point(100, 48);
			this.UsernameTextBox.Name = "UsernameTextBox";
			this.UsernameTextBox.Size = new System.Drawing.Size(222, 21);
			this.UsernameTextBox.TabIndex = 3;
			this.UsernameTextBox.Text = global::FogBugzPivot.Properties.Settings.Default.Username;
			// 
			// UrlLabel
			// 
			this.UrlLabel.AutoSize = true;
			this.UrlLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.UrlLabel.Location = new System.Drawing.Point(5, 25);
			this.UrlLabel.Name = "UrlLabel";
			this.UrlLabel.Size = new System.Drawing.Size(82, 13);
			this.UrlLabel.TabIndex = 0;
			this.UrlLabel.Text = "&FogBugz URL:";
			// 
			// UrlTextBox
			// 
			this.UrlTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.UrlTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::FogBugzPivot.Properties.Settings.Default, "FogBugzUrl", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.UrlTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.UrlTextBox.Location = new System.Drawing.Point(100, 22);
			this.UrlTextBox.Name = "UrlTextBox";
			this.UrlTextBox.Size = new System.Drawing.Size(222, 21);
			this.UrlTextBox.TabIndex = 1;
			this.UrlTextBox.Text = global::FogBugzPivot.Properties.Settings.Default.FogBugzUrl;
			// 
			// GenerationGroupBox
			// 
			this.GenerationGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.GenerationGroupBox.Controls.Add(this.BrowseSaveToFolderButton);
			this.GenerationGroupBox.Controls.Add(this.SaveToTextBox);
			this.GenerationGroupBox.Controls.Add(this.SaveToLabel);
			this.GenerationGroupBox.Controls.Add(this.RefreshFiltersButton);
			this.GenerationGroupBox.Controls.Add(this.PropertiesLabel);
			this.GenerationGroupBox.Controls.Add(this.FiltersComboBox);
			this.GenerationGroupBox.Controls.Add(this.GenerateButton);
			this.GenerationGroupBox.Controls.Add(this.FiltersLabel);
			this.GenerationGroupBox.Controls.Add(this.FacetsListBox);
			this.GenerationGroupBox.Enabled = false;
			this.GenerationGroupBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.GenerationGroupBox.Location = new System.Drawing.Point(12, 121);
			this.GenerationGroupBox.Name = "GenerationGroupBox";
			this.GenerationGroupBox.Size = new System.Drawing.Size(413, 313);
			this.GenerationGroupBox.TabIndex = 1;
			this.GenerationGroupBox.TabStop = false;
			this.GenerationGroupBox.Text = "Generation";
			// 
			// BrowseSaveToFolderButton
			// 
			this.BrowseSaveToFolderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BrowseSaveToFolderButton.Image = global::FogBugzPivot.Properties.Resources.Folder16;
			this.BrowseSaveToFolderButton.Location = new System.Drawing.Point(379, 248);
			this.BrowseSaveToFolderButton.Name = "BrowseSaveToFolderButton";
			this.BrowseSaveToFolderButton.Size = new System.Drawing.Size(24, 24);
			this.BrowseSaveToFolderButton.TabIndex = 7;
			this.BrowseSaveToFolderButton.UseVisualStyleBackColor = true;
			this.BrowseSaveToFolderButton.Click += new System.EventHandler(this.BrowseSaveToButtonClick);
			// 
			// SaveToTextBox
			// 
			this.SaveToTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.SaveToTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.SaveToTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
			this.SaveToTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::FogBugzPivot.Properties.Settings.Default, "SaveToPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.SaveToTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.SaveToTextBox.Location = new System.Drawing.Point(100, 250);
			this.SaveToTextBox.Name = "SaveToTextBox";
			this.SaveToTextBox.Size = new System.Drawing.Size(274, 21);
			this.SaveToTextBox.TabIndex = 6;
			this.SaveToTextBox.Text = global::FogBugzPivot.Properties.Settings.Default.SaveToPath;
			// 
			// SaveToLabel
			// 
			this.SaveToLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.SaveToLabel.AutoSize = true;
			this.SaveToLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.SaveToLabel.Location = new System.Drawing.Point(6, 253);
			this.SaveToLabel.Name = "SaveToLabel";
			this.SaveToLabel.Size = new System.Drawing.Size(53, 13);
			this.SaveToLabel.TabIndex = 5;
			this.SaveToLabel.Text = "&Save to:";
			// 
			// RefreshFiltersButton
			// 
			this.RefreshFiltersButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.RefreshFiltersButton.Image = global::FogBugzPivot.Properties.Resources.Refresh16;
			this.RefreshFiltersButton.Location = new System.Drawing.Point(380, 18);
			this.RefreshFiltersButton.Name = "RefreshFiltersButton";
			this.RefreshFiltersButton.Size = new System.Drawing.Size(24, 24);
			this.RefreshFiltersButton.TabIndex = 2;
			this.RefreshFiltersButton.UseVisualStyleBackColor = true;
			this.RefreshFiltersButton.Click += new System.EventHandler(this.RefreshFiltersButtonClick);
			// 
			// PropertiesLabel
			// 
			this.PropertiesLabel.AutoSize = true;
			this.PropertiesLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.PropertiesLabel.Location = new System.Drawing.Point(5, 47);
			this.PropertiesLabel.Name = "PropertiesLabel";
			this.PropertiesLabel.Size = new System.Drawing.Size(69, 13);
			this.PropertiesLabel.TabIndex = 3;
			this.PropertiesLabel.Text = "&Properties:";
			// 
			// ContainerPanel
			// 
			this.ContainerPanel.Controls.Add(this.GenerationGroupBox);
			this.ContainerPanel.Controls.Add(this.ConnectionGroupBox);
			this.ContainerPanel.Controls.Add(this.LogoffButton);
			this.ContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ContainerPanel.Location = new System.Drawing.Point(0, 0);
			this.ContainerPanel.Name = "ContainerPanel";
			this.ContainerPanel.Size = new System.Drawing.Size(434, 471);
			this.ContainerPanel.TabIndex = 0;
			// 
			// StatusLabel
			// 
			this.StatusLabel.AutoSize = true;
			this.StatusLabel.Location = new System.Drawing.Point(32, 442);
			this.StatusLabel.Name = "StatusLabel";
			this.StatusLabel.Size = new System.Drawing.Size(0, 13);
			this.StatusLabel.TabIndex = 2;
			// 
			// BusyAnimationControl
			// 
			this.BusyAnimationControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.BusyAnimationControl.AnimationInterval = 46;
			this.BusyAnimationControl.BaseImage = null;
			this.BusyAnimationControl.Columns = 18;
			this.BusyAnimationControl.Location = new System.Drawing.Point(13, 442);
			this.BusyAnimationControl.Name = "BusyAnimationControl";
			this.BusyAnimationControl.Rows = 1;
			this.BusyAnimationControl.Size = new System.Drawing.Size(0, 0);
			this.BusyAnimationControl.SkipFirstFrame = false;
			this.BusyAnimationControl.StaticImage = false;
			this.BusyAnimationControl.TabIndex = 1;
			this.BusyAnimationControl.Text = "animationControl1";
			this.BusyAnimationControl.Visible = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(434, 471);
			this.Controls.Add(this.StatusLabel);
			this.Controls.Add(this.BusyAnimationControl);
			this.Controls.Add(this.ContainerPanel);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(450, 510);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FogBugz Pivot";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
			this.ConnectionGroupBox.ResumeLayout(false);
			this.ConnectionGroupBox.PerformLayout();
			this.GenerationGroupBox.ResumeLayout(false);
			this.GenerationGroupBox.PerformLayout();
			this.ContainerPanel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button LogoffButton;
		private System.Windows.Forms.ComboBox FiltersComboBox;
		private System.Windows.Forms.Label FiltersLabel;
		private System.Windows.Forms.Button GenerateButton;
		private System.Windows.Forms.CheckedListBox FacetsListBox;
		private System.Windows.Forms.GroupBox ConnectionGroupBox;
		private System.Windows.Forms.Button LogonButton;
		private System.Windows.Forms.Label PasswordLabel;
		private System.Windows.Forms.TextBox PasswordTextBox;
		private System.Windows.Forms.Label UsernameLabel;
		private System.Windows.Forms.TextBox UsernameTextBox;
		private System.Windows.Forms.Label UrlLabel;
		private System.Windows.Forms.TextBox UrlTextBox;
		private System.Windows.Forms.GroupBox GenerationGroupBox;
		private System.Windows.Forms.Label PropertiesLabel;
		private System.Windows.Forms.Button RefreshFiltersButton;
		private System.Windows.Forms.Panel ContainerPanel;
		private wyDay.Controls.AnimationControl BusyAnimationControl;
		private System.Windows.Forms.Label StatusLabel;
		private System.Windows.Forms.Button BrowseSaveToFolderButton;
		private System.Windows.Forms.TextBox SaveToTextBox;
		private System.Windows.Forms.Label SaveToLabel;
	}
}

