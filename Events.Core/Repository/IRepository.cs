using System;
using System.Collections.Generic;
using System.Xml;

using System.Threading.Tasks;
using System.Xml.Linq;

namespace EventsAPI.Core.Repository
{
  public interface IRepository<TEntity>: IDisposable where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity> GetByIdAsync(int id);
        void Add(TEntity entity);
        void Delete(TEntity entity);
        Task<TEntity> GetEventsdataAsync(int id, string eventtype);
       }
}
