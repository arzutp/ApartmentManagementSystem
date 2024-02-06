using ApartmentManagementSystem.Core.DataAccess;
using ApartmentManagementSystem.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.DataAccess.Abstract
{
    public interface IInvoiceTypeRepository: IRepository<InvoiceType>
    {
        Task DeleteAsync(int id);
        Task<InvoiceType> GetById(int id);
    }
}
