using ApartmentManagementSystem.Core.DataAccess;
using ApartmentManagementSystem.Entities.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.DataAccess.Abstract
{
    public interface IUserRepository : IRepository<User>
    {
        Task<User> GetById(Guid id);
        Task DeleteAsync(Guid id);
        
    }
}
