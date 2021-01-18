using System;
using System.Collections.Generic;
using System.Text;

namespace EventsAPI.Core.Entities
{   
    public class Customer
    {     
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string SurNamePrefo { get; set; }

        public string Email { get; set; }

        public string MobilePhone { get; set; }
        
        public string Address { get; set; }

        public string Description { get; set; }
     
    }
}
