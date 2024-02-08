using ApartmentManagementSystem.Core.BaseEntity;
using ApartmentManagementSystem.Core.DataAccess;
using ApartmentManagementSystem.Entities.DTOs.PaymentInformationDtos;
using ApartmentManagementSystem.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.DataAccess.Abstract
{
    public interface IPaymentInformationRepository: IRepository<PaymentInformation>
    {
        Task DeleteAsync(int id);
        Task<PaymentInformation> GetById(int id);
        Task<List<PaymentGetByMonth>> GetByMonth(int month);
        Task<decimal> GetByMonthTotal(int flatId, int month);
        Task<List<PaymentGetByYear>> GetByYear(int year);
        Task<decimal> GetByYearTotal(int flatId, int year);
    }
}
