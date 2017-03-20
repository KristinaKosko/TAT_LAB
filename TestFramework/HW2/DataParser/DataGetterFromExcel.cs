using System;
using System.Collections.Generic;
using Excel = Microsoft.Office.Interop.Excel;
namespace HW2
{
    public class DataGetterFromExcel
    {
        public static Excel.Application excelApp;
        public static Excel.Workbook workbook;
        public static Excel.Sheets worksheets;
        public static List<string> namesOfJournals;
        public static List<NavigationItem> navigationItems = new List<NavigationItem>();
        public static List<SubmenuItem> submenuItems = new List<SubmenuItem>();
        public static int startRows = Convert.ToInt16(TestData.startRows);
        public static int startColumns = Convert.ToInt16(TestData.startColumns);

        public static List<string> GetNamesOfJournals(short batchNumber)
        {
            using (var excelReader = new ExcelReader()) {
                var path = GetFilePath(batchNumber);
                var workbook = excelReader.OpenWorkbook(path);
                var worksheets = excelReader.GetWorksheets(path);
                namesOfJournals = new List<string>();
                foreach (Excel.Worksheet worksheet in worksheets)
                {
                    namesOfJournals.Add(worksheet.Name);
                }
                return namesOfJournals;
            }
        }

        public static Journal ImportJournal(short batchNumber, string journalName)
        {
            return new Journal(journalName, GetNavigationItems(batchNumber, journalName));
        }

        public static string GetFilePath(short batchNumber)
        {
            return ($"{TestData.ExcelPath}\\{TestData.FileName}{batchNumber}");
        }

        public static List<NavigationItem> GetNavigationItems(short batchNumber, string nameOfJournal)
        {
            using (var excelReader = new ExcelReader())
            {
                var workbook = excelReader.OpenWorkbook(GetFilePath(batchNumber));
                var worksheet = (Microsoft.Office.Interop.Excel.Worksheet)excelReader.GetWorksheet(GetFilePath(batchNumber), nameOfJournal);
                for (int columns = startColumns; columns <= worksheet.Columns.Count; columns++)
                {
                    var navigationItem = new NavigationItem();
                    navigationItem.name = GetValue(startRows, columns, worksheet);
                    if (navigationItem.name != "")
                    {
                        for (int i = Convert.ToInt16(startRows) + 1; i <= worksheet.Rows.Count; i++)
                        {
                            SubmenuItem submenuItem = new SubmenuItem();
                            submenuItem.name = GetValue(i, columns, worksheet);
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
         }

        public static string GetValue(int row, int col, Excel.Worksheet worksheet)
        {
            Excel.Range cell = (Excel.Range)worksheet.Cells[row, col];
            return Convert.ToString(cell.Value);

        }
    }
}
