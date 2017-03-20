using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XMLToLinq
{
    public class WorkerWithCustomers
    {
        public static List<string> GroupByCountry()
        {
            List<string> customersByCountry = new List<string>();
            var listOfCountries = GetterDataFromXML.GetCountries();
            foreach (var country in listOfCountries)
            {
                var items = from customer in XMLFileReader.OpenXMLDocument().Element("customers").Elements("customer")
                            where customer.Element("country").Value == country
                            select customer;
                foreach (var item in items)
                {
                    customersByCountry.Add(item.Value);
                }
            }
            return customersByCountry;
        }

        public static List<string> GetCustomersIfSumOfOrdersHigherX(double x)
        {
            List<string> customersByOrdersTotal = new List<string>();
            var customers = from customer in XMLFileReader.OpenXMLDocument().Element("customers").Elements("customer")
                            select customer;
            foreach (var customer in customers)
            {
                double total = 0;
                var items = (from order in XMLFileReader.OpenXMLDocument().Element("orders").Elements("order")
                            select new { order.Descendants("total").SingleOrDefault().Value }).ToList();
                foreach (var item in items) { total += Convert.ToDouble(item); }
                if (IsTotalHigherThanX(total, x)) { AddToList(customersByOrdersTotal, customer); }
            }
            return customersByOrdersTotal;
        }

        public static bool IsTotalHigherThanX(double total, double x)
        {
            if (total > x) { return true; } else return false;
        }

        public static void AddToList(List<string> list, XElement itemToAdd)
        {
            list.Add(itemToAdd.Value);
        }
    } 
}
