using System;
using System.Collections.Generic;

namespace HW2
{
	public class Journal
	{
		public string name { get; set;}
		public List<NavigationItem> navigationItems { get; set;}

		public Journal(string name, List<NavigationItem> navigationItems)
		{
			this.name = name;
			this.navigationItems = navigationItems;
		}
	}
}
