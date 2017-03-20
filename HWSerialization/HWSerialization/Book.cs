using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HWSerialization
{
    [Serializable]
    public class Book
    {
        private DateTime publishDate;
        private DateTime registrationDate;

        [XmlAttribute("id")]
        public string Id { get; set; }
        [XmlAttribute("isbn")]
        public string Isbn { get; set; }
        [XmlAttribute("author")]
        public string Author { get; set; }
        [XmlAttribute("Title")]
        public string Title { get; set; }
        [XmlElement("genre")]
        public Genre Genre { get; set; }
        [XmlAttribute("publisher")]
        public string Publisher { get; set; }
        [XmlAttribute("publish_date")]
        public string PublishDate {
            get
            {
                return publishDate.ToString("yyyy-MM-dd");
            }
            set
            {
                publishDate = DateTime.Parse(value);
            }
        }
        [XmlAttribute("description")]
        public string Description { get; set; }
        [XmlAttribute("registration_date")]
        public string RegistrationDate
        {
            get
            {
                return registrationDate.ToString("yyyy-MM-dd");
            }
            set
            {
                registrationDate = DateTime.Parse(value);
            }
        }
        
    }

    public enum Genre
    {
        [XmlEnum("Computer")]
        Computer,
        [XmlEnum("Romance")]
        Romance,
        [XmlEnum("Fantasy")]
        Fantasy,
        [XmlEnum("Horror")]
        Horror
    }
}
