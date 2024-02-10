using ApartmentManagementSystem.Entities.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.DataAccess.Extensions
{
    public static class RegularlyPayUserExtensions
    {
        public static void AddRegularlyUser(this DbContext context, Guid userId, int? invoiceTypeId, int month, int year)
        {
            var isAnyUser = context.Set<RegularlyPayUser>().FirstOrDefault(x => x.UserId == userId && x.InvoiceTypeId == invoiceTypeId && x.Year == year);

            RegularlyPayUser regularlyPayUser = new RegularlyPayUser
            {
                UserId = userId,
                InvoiceTypeId = invoiceTypeId,
                Year = year
            };
            if (isAnyUser != null)
            {
                
                if (month <= DateTime.Now.Month)
                {
                    isAnyUser.Index = 0;
                }
                else { isAnyUser.Index = isAnyUser.Index + 1; }
                context.Set<RegularlyPayUser>().Update(isAnyUser);
            }
            else
            {
                regularlyPayUser.Index++;
                context.Set<RegularlyPayUser>().Add(regularlyPayUser);
            }
        }
    }
}
