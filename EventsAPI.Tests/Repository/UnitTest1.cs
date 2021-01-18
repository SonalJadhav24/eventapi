using System;
using EventsAPI.Core.Entities;
using EventsAPI.Services;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using EventsAPI.Core.Repository;

using System.Threading.Tasks;

namespace EventsAPI.Tests.Repository
{
    [TestClass]
    public class EventRepositoryTest
    {
        [TestMethod]
        public void IsRepositoryReturnsSameCustomerTrasactionWithID()
        {
            //Arrange
            CustomerTransaction cust_transaction = new CustomerTransaction();
            var mockEventRepository = new Mock<ICustomerTransactionRepository>() ;
            
            //Act
            mockEventRepository.Setup(r => r.GetByIdAsync(1)).Returns(Task.FromResult(cust_transaction));
          //  var result = controller.GetBookByID(1) as OkNegotiatedContentResult<Book>;

            //Assert
          //  Assert.IsNotNull(result);
      
        }
    }
}
