using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XMLToLinq
{
    public class XMLFileReader
    {
        public XMLFileReader()
        {}

        public static string GetFilePath()
        {
            return ($"{TestData.FilePath}/{TestData.FileName}");
        }

        public static XDocument OpenXMLDocument()
        {
            return (XDocument.Load(GetFilePath()));
        }

        public static void PrintItems(List<string> itemList)
        {
            foreach (var item in itemList)
            {
                Console.WriteLine(item);
            }
        }

        public static void WriteToFile(List<string> textToWrite, string outputFileName)
        {
            StreamWriter sw = new StreamWriter($"{TestData.OutputFilePath}/{outputFileName}", false);
            foreach (var line in textToWrite)
            {
                sw.WriteLine(line);
            }
            // Записываем текущие дату и время в файл
            // sw.WriteLine("Текущие дата и время (время UTC):  " + DateTime.UtcNow.ToString());
           sw.Close();
        }
    }
}
