using System.Collections.ObjectModel;

namespace FogBugzPivot
{
	public class FacetCollection : KeyedCollection<string, Facet>
	{
		public static FacetCollection Default = new FacetCollection
		{
			new Facet { Name = "ixBug", DisplayName = "Id", IsFilter = true, Type = "Number" },
			new Facet { Name = "sTitle", DisplayName = "Title", IsFilter = false },
			new Facet { Name = "sStatus", DisplayName = "Status", IsFilter = true },
			new Facet { Name = "sArea", DisplayName = "Area", IsFilter = true },
			new Facet { Name = "sPersonAssignedTo", DisplayName = "Assigned To", IsFilter = true },
			new Facet { Name = "sPriority", DisplayName = "Priority", IsFilter = true },
			new Facet { Name = "sFixFor", DisplayName = "Milestone", IsFilter = true },
			new Facet { Name = "sCategory", DisplayName = "Category", IsFilter = true },
			new Facet { Name = "dtOpened", DisplayName = "Opened On", IsFilter = true, Type = "DateTime" },
			new Facet { Name = "dtResolved", DisplayName = "Resolved On", IsFilter = true, Type = "DateTime" },
			new Facet { Name = "dtClosed", DisplayName = "Closed On", IsFilter = true, Type = "DateTime" },
		};

		protected override string GetKeyForItem(Facet facet)
		{
			return facet.Name;
		}
	}
}