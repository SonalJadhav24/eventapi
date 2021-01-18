using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAPI.Services
{

    public interface IService<TEntity> : IDisposable where TEntity : class
    {
        void Update(TEntity TEntity);
        Task UpdateAsync(TEntity TEntity);
        void Delete(TEntity entity);
        Task DeleteAsync(TEntity entity);
        Task GetAll(TEntity entity);
        Task<List<TEntity>> GetAllAsync();
        Task<TEntity> GetAsyncByID(int id);
        Task<TEntity> GetSelectedEventsData(int id, string eventtype);
    }
}
