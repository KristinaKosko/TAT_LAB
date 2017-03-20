using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HWSerialization
{
    [Serializable]
    [XmlRootAttribute("catalog", Namespace = "http://library.by/catalog", IsNullable = false)]
    class Catalog
    {
        private DateTime date;

        [XmlAttribute("date")]
        public string Date { get { return date.ToString("yyyy-MM-dd"); }set { date = DateTime.Parse(value); } }

        [XmlArrayItem(Type = typeof(Book))]
        public Book[] Books { get; set; }

        public Catalog()
        {
            Books = new List<Book>().ToArray();
        }

        public Catalog(List<Book> books)
        {
            Books = books.ToArray();
        }
    }
}
