using ApartmentManagementSystem.DataAccess.Abstract;
using ApartmentManagementSystem.DataAccess.EntityFramework.Context;
using ApartmentManagementSystem.Entities.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.DataAccess.EntityFramework.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(ApartmentManagementDbContext context) : base(context)
        {
        }

        public async Task DeleteAsync(Guid id)
        {
            var result = await _context.Set<User>().FirstOrDefaultAsync(x => x.Id.Equals(id));
            _context.Remove(result!);
        }

        public async Task<User> GetById(Guid id)
        {
            var result = await _context.Set<User>().AsNoTracking().FirstOrDefaultAsync(x => x.Id.Equals(id));
            return result;
        }
    }
}
