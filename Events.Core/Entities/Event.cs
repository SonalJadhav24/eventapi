using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace EventsAPI.Core.Entities
{
    [XmlRoot("Customer_Transaction")]  
    public class Event
    {       
        [XmlElement(ElementName = "ID")]
        public int ID { get; set; }
        [XmlElement(ElementName = "Name")]
        public string Name { get; set; }  
      
        [XmlElement(ElementName = "Event_type")]
        public string Event_type { get; set; }
        [XmlElement(ElementName = "Point")]
        public int Point { get; set; }
        [XmlElement("product")]
        public List<Product> Products { get ; set ; }


    }
}
