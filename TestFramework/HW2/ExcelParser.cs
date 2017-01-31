using System;
using System.Collections.Generic;
using Excel = Microsoft.Office.Interop.Excel;
namespace HW2
{
	public static class ExcelParser
	{
		public static string path = "/Users/kristinakosko/Desktop/TAT_LAB/TestFramework/Responsive-Batch-4.xlsx";
		public static Excel.Application excelApp;
		public static Excel.Workbook wb;
		public static Excel.Sheets worksheets;
		public static List<string> namesOfJournals;
		public static List<NavigationItem> navigationItems;
		public static List<SubmenuItem> submenuItems;
		public static int startRows = 2;
		public static int startColumns = 1;

		public static List<string> GetNamesOfJournals()
		{
			excelApp = new Excel.Application();
			wb = excelApp.Workbooks.Open(path);
			worksheets = wb.Worksheets;
			namesOfJournals = new List<string>();
			foreach (Excel.Worksheet worksheet in worksheets)
			{
				namesOfJournals.Add(worksheet.Name);
			}
			return namesOfJournals;
		}

		public static List<NavigationItem> GetNavigationItems(string nameOfJournal)
		{
			worksheets.Select(nameOfJournal);
			Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)wb.ActiveSheet; 
			var range = ws.Cells[startRows, startColumns];
			while (range != null)
			{
				for (int columns = startColumns; columns <= ws.Columns.Count; columns++)
				{
					var navigationItem = new NavigationItem();
					navigationItem.name = ws.Cells[startRows, columns].ToString();
					while (range != null)
					{
						for (int i = startRows + 1; i <= ws.Rows.Count; i++)
						{
							range = ws.Cells[i, startColumns];
							GetSubmenuItems(i, ws);
							/*var submenuItem = new SubmenuItem();
							submenuItem.name = ws.Cells[i, startColumns].ToString();
							submenuItems.Add(submenuItem);*/
						}
					}
					navigationItem.submenuItems = submenuItems;
					navigationItems.Add(navigationItem);
				}
			}
			return navigationItems;
		}

		public static List<SubmenuItem> GetSubmenuItems(int row, Excel.Worksheet ws)
		{
			var submenuItem = new SubmenuItem();
			submenuItem.name = ws.Cells[row, startColumns].ToString();
			submenuItems.Add(submenuItem);
			return submenuItems;
		}
	}
}
