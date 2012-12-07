using System.Xml;

namespace FogBugzPivot
{
	public class Facet
	{
		public Facet()
		{
			Type = "String";
		}

		public string Name { get; set; }

		public string DisplayName { get; set; }

		public string Type { get; set; }

		public bool IsFilter { get; set; }

		public void WriteTo(XmlWriter writer, string value)
		{
			if (string.IsNullOrEmpty(value))
			{
				if ("DateTime".Equals(Type))
				{
					value = "0001-01-01T00:00:00Z";
				}
				else if ("Number".Equals(Type))
				{
					value = "0";
				}
			}

			writer.WriteStartElement("Facet");
			writer.WriteAttributeString("Name", DisplayName);

			writer.WriteStartElement(Type);
			writer.WriteAttributeString("Value", value);
			writer.WriteEndElement(); // Type

			writer.WriteEndElement(); // Facet
		}
	}
}