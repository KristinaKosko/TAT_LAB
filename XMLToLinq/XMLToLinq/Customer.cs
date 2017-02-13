using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLToLinq
{
    public class Customer
    {
        public string ID { get; set; }
        public List<Order> Orders { get; set; }
        public string Country { get; set; }

        public Customer(string id, string country, List<Order> orders)
        {
            ID = id;
            Country = country;
            Orders = orders;
        }

        public override string ToString()
        {
            return ID;
        }
    }
}
