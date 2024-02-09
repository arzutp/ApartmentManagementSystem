using ApartmentManagementSystem.Core.DataAccess;
using ApartmentManagementSystem.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.DataAccess.Abstract
{
    public interface IRoleRepository : IRepository<Role>
    {
        public Task<Role> GetByTenant();
    }
}
