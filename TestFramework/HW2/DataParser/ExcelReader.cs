using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace HW2
{
    public class ExcelReader : IDisposable
    {
        private readonly Excel.Application app;

        public ExcelReader()
        {
            app = new Excel.Application();
        }

        ~ExcelReader()
        {
            Dispose();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposing) return;
            app?.Quit();
        }

        public Excel.Application OpenWorkbook(string workbookPath)
        {
            app.Workbooks.Open(workbookPath);
            return app;
        }

        public Excel.Sheets GetWorksheets(string filePath)
        {
            return OpenWorkbook(filePath).ActiveWorkbook.Worksheets;
        }

        public Excel.Worksheet GetWorksheet(string filePath, string worksheetName)
        {
            return (Excel.Worksheet)OpenWorkbook(filePath).ActiveWorkbook.Worksheets[worksheetName];
        }
    }
}
