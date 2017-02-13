using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLToLinq
{
    public class GetterDataFromXML
    {
        public static HashSet<string> GetCountries()
        {
            HashSet<string> listOfCountries = new HashSet<string>();
            var items = from customer in XMLFileReader.OpenXMLDocument().Element("customers").Elements("customer")
                        select customer.Element("country").Value;
            foreach (var country in items)
            {
                listOfCountries.Add(country);
            }
            return listOfCountries;
        }
    }
}
