using System;
using System.Collections.Generic;

namespace HW2
{
	public class NavigationItem
	{
		public string name { get; set; }
		public List<SubmenuItem> submenuItems{ get; set; }

		public NavigationItem(string name, List<SubmenuItem> submenuItems)
		{
			this.name = name;
			this.submenuItems = submenuItems;
		}

		public NavigationItem()
		{
            submenuItems = new List<SubmenuItem>();
		}
	}
}
