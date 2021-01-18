
using System;
using System.Xml.Serialization;

namespace EventsAPI.Core.Entities
{
    [XmlRoot("product")]
    public class Product
    {
        [XmlElement("ProductID")]
        public int ProductID { get; set; }
        [XmlElement("ProductName")]
        public string ProductName { get; set; }
        [XmlElement("Description")]
        public string Description { get; set; }
        [XmlElement("Priceindollars")]
        public double Priceindollars { get; set; }
        [XmlElement("ProductWeight")]
        public double ProductWeight { get; set; }
        [XmlElement("ProductHeight")]
        public double ProductHeight { get; set; }

    }
}
