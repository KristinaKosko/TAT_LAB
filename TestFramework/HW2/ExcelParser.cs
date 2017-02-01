using System;
using System.Collections.Generic;
using Excel = Microsoft.Office.Interop.Excel;
namespace HW2
{
    public class ExcelParser
    {
        public static string path = @"C:\Users\Krystsina_Kasko\Desktop\TAT_LAB-TestJournalFramework\TestFramework\Responsive-Batch-4.xlsx";
        public static Excel.Application excelApp;
        public static Excel.Workbook wb;
        public static Excel.Sheets worksheets;
        public static List<string> namesOfJournals;
        public static List<NavigationItem> navigationItems = new List<NavigationItem>();
        public static List<SubmenuItem> submenuItems = new List<SubmenuItem>();
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
            Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)wb.Worksheets[nameOfJournal];
            for (int columns = startColumns; columns <= ws.Columns.Count; columns++)
            {
                var navigationItem = new NavigationItem();
                navigationItem.name = GetValue(startRows, columns, ws);
                if (navigationItem.name != "")
                {
                    for (int i = startRows + 1; i <= ws.Rows.Count; i++)
                    {
                        SubmenuItem submenuItem = new SubmenuItem();
                        submenuItem.name = GetValue(i, columns, ws);
                        if (submenuItem.name != "")
                        {
                            navigationItem.submenuItems.Add(submenuItem);
                        }
                        else
                        {
                            break;
                        }
                    }
                    navigationItems.Add(navigationItem);
                }
                else
                {
                    break;
                }
            }
            return navigationItems;
        }

        public static string GetValue(int row, int col, Excel.Worksheet ws)
        {
            Excel.Range cell = (Excel.Range)ws.Cells[row, col];
            return Convert.ToString(cell.Value);

        }
    }
}
