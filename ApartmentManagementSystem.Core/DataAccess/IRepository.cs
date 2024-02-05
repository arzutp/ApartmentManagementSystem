using ApartmentManagementSystem.Core.BaseEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.Core.DataAccess
{
    public interface IRepository<T> where T : class, IEntity
    {
        Task<T> AddAsync(T entity);
        void Update(T entity);
        Task DeleteAsync(int id);
        IQueryable<T> GetAllAsync();
        Task<T> GetById(int id);
    }
}
