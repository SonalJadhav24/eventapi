using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace EventsAPI.Core.Entities
{   
    [ XmlRoot("Customer_Transaction")]
    public class CustomerTransaction
    {
        [XmlElement(ElementName = "Cust_id")]
        public int Cust_id { get; set; }
        [XmlElement("customer")]
        public Customer Customer { get; set; }       
        [XmlElement("event")]
        public List<Event> Events = new List<Event>();
    }
}
