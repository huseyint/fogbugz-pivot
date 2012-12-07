using System.Xml.Linq;

namespace FogBugzPivot
{
	public class FilterComboItem
	{
		private readonly string _id;
		private readonly string _name;

		public FilterComboItem(XElement filterElement)
		{
			_id = filterElement.Attribute("sFilter").Value;
			_name = filterElement.Value;
		}

		public string Id
		{
			get { return _id; }
		}

		public string Name
		{
			get { return _name; }
		}

		public override string ToString()
		{
			return _name;
		}

		protected bool Equals(FilterComboItem other)
		{
			return string.Equals(_id, other._id);
		}

		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj))
			{
				return false;
			}

			if (ReferenceEquals(this, obj))
			{
				return true;
			}

			return obj.GetType() == GetType() && Equals((FilterComboItem)obj);
		}

		public override int GetHashCode()
		{
			return _id != null ? _id.GetHashCode() : 0;
		}
	}
}