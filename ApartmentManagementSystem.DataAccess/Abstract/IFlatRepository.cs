using ApartmentManagementSystem.Core.DataAccess;
using ApartmentManagementSystem.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.DataAccess.Abstract
{
    public interface IFlatRepository : IRepository<Flat>
    {
        Task DeleteAsync(int id);
        Task<Flat> GetById(int id);
        
    }
}
