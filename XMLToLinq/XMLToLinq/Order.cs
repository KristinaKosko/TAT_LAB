using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLToLinq
{
    public class Order
    {
        public int ID { get; set; }
        public TimeSpan Date { get; set; }
        public float Total { get; set; }

        public Order(int id, TimeSpan date, float total)
        {
            ID = id;
            Date = date;
            Total = total;
        }
    }
}
