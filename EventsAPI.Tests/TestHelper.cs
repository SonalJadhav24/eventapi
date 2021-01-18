using EventsAPI.Core.Entities;
using System.Collections.Generic;

namespace EventsAPI.Tests
{
    internal static class TestHelper
    {
     
        internal static List<Event> Getdemoevents()
        {
            List<Event> events = new List<Event>();
            Event event1 = new Event
            {
                ID = 101,
                Event_type = "fixed",
                Name = "watches",
                Point = 100
            };
            event1.Products.AddRange(Getdemoproducts());
            events.Add(event1);
            return events;
        }
        internal static List<Product> Getdemoproducts()
        {
            Product product1 = new Product
            {
                ProductID = 10,
                Description = "temp",
                Priceindollars = 10,
                ProductHeight = 10,
                ProductName = "pr1",
                ProductWeight = 100
            };
            List<Product> products = new List<Product>
            {
                product1,
                product1
            };
            return products;

        }
        internal static CustomerTransaction GetDemoCustomerTransaction()
        {
            CustomerTransaction customerTransaction = new CustomerTransaction
            {
                Cust_id = 1
            };
            Customer Customer = new Customer
            {
                Address = "tempaddress",
                Description = "tempdescription",
                Email = "tempemail",
                FirstName = "tempfirstname",
                LastName = "templastname",
                MobilePhone = "123445"
            };

            customerTransaction.Events.AddRange(Getdemoevents());
            return customerTransaction;

        }    
    }
}
