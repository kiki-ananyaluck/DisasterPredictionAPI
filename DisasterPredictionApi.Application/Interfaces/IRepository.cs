using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisasterPredictionApi.Application.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<T?> GetById(int id);
        Task<IEnumerable<T>> GetAll();
        Task Add(T entity);
        void Update(T entity);
        void Remove(T entity);
    }
}
