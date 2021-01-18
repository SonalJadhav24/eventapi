

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EventsAPI.Core.Repository;
using EventsAPI.Core.Entities;
using EventsAPI.Services;

namespace EventsAPI.Services
{
    public class CustomerTransactionService : ICustomerTransactionService
    {
            private readonly ICustomerTransactionRepository _customerTransactionrepository;

        public CustomerTransactionService(ICustomerTransactionRepository customerTransactionRepository )
        {

            _customerTransactionrepository = customerTransactionRepository;
        }

        public void Delete(CustomerTransaction entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(CustomerTransaction entity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task GetAll(CustomerTransaction entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<CustomerTransaction>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<CustomerTransaction> GetAsyncByID(int id)
        {
          return  await ( _customerTransactionrepository.GetByIdAsync(id));
        }

        public  Task<CustomerTransaction> GetSelectedEventsData(int id, string eventtype)
        {
            return (_customerTransactionrepository.GetEventsdataAsync(id, eventtype));
        }

        public void Update(CustomerTransaction TEntity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(CustomerTransaction TEntity)
        {
            throw new NotImplementedException();
        }
    }
}
