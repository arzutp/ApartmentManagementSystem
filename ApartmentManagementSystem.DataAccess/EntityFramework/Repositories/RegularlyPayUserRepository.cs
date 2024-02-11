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

        public RegularlyPayUser GetByInvoiceName(string invoiceName)
        {
            var result = _context.Set<RegularlyPayUser>().Include(x=>x.InvoiceType).FirstOrDefault(x=>x.InvoiceType.Name.ToLower() == invoiceName.ToLower());
            return result;
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
                    Index = x.Index
                }).ToList();
            return results;
        }

        public List<RegularlyPayUser> RegularlyPayUserGetByYear(int year, string name, int index)
        {
            var invoiceTypeName = GetByInvoiceName(name);
            var result = _context.Set<RegularlyPayUser>().Where(x => x.Year == year && x.InvoiceTypeId == invoiceTypeName.InvoiceTypeId && x.Index >= index).ToList();
            return result;
        }

        public bool IsDiscountForUser(Guid? userId, int year, int? invoiceTypeId, int index)
        {
            var name = GetByInvoiceName("Aidat");
            if (name.InvoiceTypeId != invoiceTypeId)
            {
                return false;
            }
            var datas = RegularlyPayUserGetByYear(year, "Aidat", index);
            var result = datas.Any(x => x.UserId == userId);
            return result;
        }
    }
}
