using ApartmentManagementSystem.Core.Utilities;
using ApartmentManagementSystem.Entities.DTOs.FlatDtos;
using ApartmentManagementSystem.Entities.DTOs.InvoiceTypeDtos;
using ApartmentManagementSystem.Entities.DTOs.PaymentInformationDtos;
using ApartmentManagementSystem.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.Business.Abstract
{
    public interface IPaymentInformationService
    {
        IDataResult<List<PaymentInformationGetAllDto>> GetAll();
        Task<IResult> Add(PaymentInformationAddDto entity);
        Task<IResult> AddRangeAsync(List<PaymentInformationAddDto> datas);
        Task<IResult> Update(PaymentInformationUpdateDto entity);
        Task<IResult> Delete(int id);
        Task<IDataResult<PaymentInformationGetByIdDto>> GetById(int id);
        Task<IDataResult<List<PaymentGetByMonth>>> GetByMonth(int month);
        Task<IDataResult<decimal>> GetByMonthTotal(int flatId, int month);
        Task<IDataResult<Dictionary<int, decimal>>> GetByMonthTotalWithFlat(int month);
        Task<IDataResult<List<PaymentGetByYear>>> GetByYear(int year);
        Task<IDataResult<decimal>> GetByYearTotal(int flatId, int year);
        Task<IDataResult<Dictionary<int, decimal>>> GetByYearTotalWithFlat(int year);
        Task<IDataResult<List<PaymentGetByUser>>> GetByUser(Guid userId);
        Task<IDataResult<List<PaymentGetByBuilding>>> GetByBuildingNumber(int buildingNumber);
        Task<IDataResult<List<PaymentGetByMonth>>> GetByMonthForUser(int month, Guid userId);
        Task<IDataResult<List<PaymentGetByYear>>> GetByYearForUser(int year, Guid userId);
        Task<IResult> UserPayInvoice(int entity, string paymendType,Guid userId);
    }
}
