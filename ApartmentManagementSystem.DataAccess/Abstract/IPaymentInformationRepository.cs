﻿using ApartmentManagementSystem.Core.BaseEntity;
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
        Task<Dictionary<int, decimal>> GetByMonthTotalWithFlat(int month);
        Task<List<PaymentGetByYear>> GetByYear(int year);
        Task<decimal> GetByYearTotal(int flatId, int year);
        Task<Dictionary<int, decimal>> GetByYearTotalWithFlat(int year);
        Task<List<PaymentGetByUser>> GetByUser(Guid userId);
        Task<List<PaymentGetByBuilding>> GetByBuildingNumber(int buildingNumber);
        Task<List<PaymentGetByMonth>> GetByMonthForUser(int month, Guid userId);
        Task<List<PaymentGetByYear>> GetByYearForUser(int year, Guid userId);
        Task<decimal> UserPayInvoice(int id, string paymendType, Guid userId);
    }
}
