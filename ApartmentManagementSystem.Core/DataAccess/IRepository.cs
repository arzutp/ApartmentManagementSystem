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
        Task Update(T entity); 
        List<T> GetAll();
        
    }
}
