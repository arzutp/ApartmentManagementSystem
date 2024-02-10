using ApartmentManagementSystem.DataAccess.Abstract;
using ApartmentManagementSystem.DataAccess.EntityFramework.Context;
using ApartmentManagementSystem.Entities.DTOs.RegularlyPayUserDto;
using ApartmentManagementSystem.Entities.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.DataAccess.EntityFramework.Repositories
{
    public class RegularlyPayUserRepository : BaseRepository<RegularlyPayUser>, IRegularlyPayUserRepository
    {
        public RegularlyPayUserRepository(ApartmentManagementDbContext context) : base(context)
        {
        }

        public List<RegularlyPayUserIndexDto> GetRegularlyPayUser(int index)
        {
            var results =  _context.Set<RegularlyPayUser>().
                Where(x=>x.Index >= index)
                .Include(x=>x.User)
                .Select(x=>new RegularlyPayUserIndexDto
                {
                    UserName = x.User.Name,
                    UserSurname = x.User.Surname,
                    Index = index
                }).ToList();
            return results;
        }
    }
}
