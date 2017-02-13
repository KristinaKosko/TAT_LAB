using Microsoft.VisualStudio.TestTools.UnitTesting;
using XMLToLinq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLToLinq.Tests
{
    [TestClass()]
    public class WorkerWithCustomersTests
    {
        List<string> customersByCountries;
        List<string> customersByTotalHigherX;

        [TestMethod()]
        public void GroupCustomersByCountryTest()
        {
            customersByCountries = new List<string>();
            customersByCountries = WorkerWithCustomers.GroupByCountry();
            XMLFileReader.WriteToFile(customersByCountries, "CustomersByCountries.txt");
        }

        [TestMethod()]
        public void GetCustomersIfSumOfOrdersHigherXTest()
        {
            customersByTotalHigherX = new List<string>();
            customersByTotalHigherX = WorkerWithCustomers.GetCustomersIfSumOfOrdersHigherX(Convert.ToDouble(TestData.BorderToCheck));
            XMLFileReader.WriteToFile(customersByTotalHigherX, "OrdersHigherX.txt");
        }
    }
}