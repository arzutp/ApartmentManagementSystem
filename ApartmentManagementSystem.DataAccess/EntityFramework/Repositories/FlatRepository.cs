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
    public class FlatRepository : BaseRepository<Flat>, IFlatRepository
    {
        public FlatRepository(ApartmentManagementDbContext context) : base(context)
        {
        }

        public async Task DeleteAsync(int id)
        {
            var result = await _context.Set<Flat>().FirstOrDefaultAsync(x => x.Id.Equals(id));
            _context.Remove(result!);
        }

        public async Task<Flat> GetById(int id)
        {
            var result = await _context.Set<Flat>().AsNoTracking().FirstOrDefaultAsync(x => x.Id.Equals(id));
            return result;
        }
    }
}
