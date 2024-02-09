using ApartmentManagementSystem.DataAccess.Abstract;
using ApartmentManagementSystem.DataAccess.EntityFramework.Context;
using ApartmentManagementSystem.Entities.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.DataAccess.EntityFramework.Repositories
{
    public class RoleRepository : BaseRepository<Role>, IRoleRepository
    {
        public RoleRepository(ApartmentManagementDbContext context) : base(context)
        {
        }

        public async Task<Role> GetByTenant()
        {
            var result =  await _context.Set<Role>().AsNoTracking().FirstOrDefaultAsync(x => x.Name.ToLower() == "Kiracı".ToLower());
            return result;
        }
    }
}
