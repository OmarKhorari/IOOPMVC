using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOPMVC.Business.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        T GetByID(int id);
        IQueryable<T> GetAll();
        Task<T> AddAsync(T entity);
        Task<T> DeleteAsync(T entity);
        Task<T> UpdateAsync(T entity);
    }
}
