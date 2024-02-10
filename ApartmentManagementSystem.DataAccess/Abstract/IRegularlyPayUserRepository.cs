using ApartmentManagementSystem.Core.DataAccess;
using ApartmentManagementSystem.Entities.DTOs.RegularlyPayUserDto;
using ApartmentManagementSystem.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.DataAccess.Abstract
{
    public interface IRegularlyPayUserRepository : IRepository<RegularlyPayUser>
    {
        List<RegularlyPayUserIndexDto> GetRegularlyPayUser(int index);
        List<RegularlyPayUser> RegularlyPayUserGetByYear(int year, string name, int index);
        RegularlyPayUser GetByInvoiceName(string invoiceName);
        bool IsDiscountForUser(Guid? userId, int year, int? invoiceTypeId, int index);
    }
}
