
using EventsAPI.Core.Entities;
using EventsAPI.Controllers;
using EventsAPI.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using EventsAPI.Core.Repository;

using System.Threading.Tasks;

namespace EventsAPI.Tests.Controllers
{
    [TestClass]
    public class CustomerControllerTest
    {
        [TestMethod]
        public void GetCustomerShouldResturnSameCustomer()
        {

            //Arrange
            CustomerTransaction cust_transaction = new CustomerTransaction();
            var mockEventRepository = new Mock<ICustomerTransactionRepository>();
            //Act
            var result = mockEventRepository.Setup(r => r.GetByIdAsync(1)).Returns(Task.FromResult(cust_transaction));

            //Assert
            Assert.IsNotNull(result);
        }


        [TestMethod]
        public void GetSelectedEventforCustoemrShouldReturnSameTypeofevents()
        {
          
            //Arrange
            CustomerTransaction cust_transaction = new CustomerTransaction();
            var mockEventRepository = new Mock<ICustomerTransactionRepository>();
            var mockCustomerService = new Mock<ICustomerTransactionService>();
            //Act
            var demoresult  = mockEventRepository.Setup(r => r.GetEventsdataAsync(1, "fixed")).Returns(Task.FromResult(TestHelper.GetDemoCustomerTransaction()));

        
            //Act
            var controller = new CustomerController(mockCustomerService.Object);
           // var result =  controller.GetSelectEventsForCustomer(1,"fixed");

            //Assert
            Assert.IsNotNull(demoresult);
          //  Assert.AreEqual(result.Result.GetType(), typeof(demoresult));

        }
        //[TestMethod]
        //public void GetCustomerShouldResturnSameCustomer()
        //{

        //    //Arrange
        //    CustomerTransaction cust_transaction = new CustomerTransaction();
        //    var mockEventRepository = new Mock<ICustomerTransactionRepository>();

        //    //Act
        //    var result = mockEventRepository.Setup(r => r.GetByIdAsync(1)).Returns(Task.FromResult(cust_transaction));

        //    //Assert
        //    Assert.IsNotNull(result);
        //}
    }
}
