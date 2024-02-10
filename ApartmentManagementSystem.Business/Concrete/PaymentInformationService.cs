using ApartmentManagementSystem.Business.Abstract;
using ApartmentManagementSystem.Business.Extensions;
using ApartmentManagementSystem.Core.BaseEntity;
using ApartmentManagementSystem.Core.Utilities;
using ApartmentManagementSystem.DataAccess.Abstract;
using ApartmentManagementSystem.Entities.DTOs.PaymentInformationDtos;
using ApartmentManagementSystem.Entities.Entity;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ApartmentManagementSystem.Business.Concrete
{
    public class PaymentInformationService : IPaymentInformationService
    {
        private readonly IPaymentInformationRepository _repository;
        private readonly IMapper _mapper;
        private readonly IRegularlyPayUserService _regularlyPayUserService;
        private readonly IFlatService _flatService;
        public PaymentInformationService(IPaymentInformationRepository repository, IMapper mapper, IFlatService flatService, IRegularlyPayUserService regularlyPayUserService)
        {
            _repository = repository;
            _mapper = mapper;
            _flatService = flatService;
            _regularlyPayUserService = regularlyPayUserService;
        }

        public async Task<IResult> Add(PaymentInformationAddDto entity)
        {
            var flat = await _flatService.GetById(entity.FlatId);
            var userId = flat!.Data.UserId;
            var dto = _mapper.Map<PaymentInformation>(entity);
            dto.UserId = userId;
            if (_regularlyPayUserService.IsDiscountForUser(dto?.UserId, dto!.Year - 1, dto.InvoiceTypeId, 12))
            {
                dto.Price = DiscountExtension.CalculateInvoicePrice(dto.Price, 10);
            }
            await _repository.AddAsync(dto);
            return new SuccessResult();
        }

        public async Task<IResult> AddRangeAsync(List<PaymentInformationAddDto> datas)
        {   
            var dto = _mapper.Map<List<PaymentInformation>>(datas);
            foreach (var data in dto)
            {
                var flat = await _flatService.GetById(data.FlatId);
                var userId = flat!.Data.UserId;
                data.UserId = userId;
                if (_regularlyPayUserService.IsDiscountForUser(data?.UserId, data!.Year - 1, data.InvoiceTypeId, 12))
                {
                    data.Price = DiscountExtension.CalculateInvoicePrice(data.Price, 10);
                }
            }
            await _repository.AddRangeAsync(dto);
            return new SuccessResult();
        }

        public async Task<IResult> Delete(int id)
        {
            await _repository.DeleteAsync(id);
            return new SuccessResult();
        }

        public IDataResult<List<PaymentInformationGetAllDto>> GetAll()
        {
            var payments = _repository.GetAll();
            var result = _mapper.Map<List<PaymentInformationGetAllDto>>(payments);
            return new SuccessDataResult<List<PaymentInformationGetAllDto>>(result);
        }

        public async Task<IDataResult<PaymentInformationGetByIdDto>> GetById(int id)
        {
            var payments = await _repository.GetById(id);
            var result = _mapper.Map<PaymentInformationGetByIdDto>(payments);
            return new SuccessDataResult<PaymentInformationGetByIdDto>(result);
        }

        public async Task<IDataResult<List<PaymentGetByMonth>>> GetByMonth(int month)
        {
            var payments = await _repository.GetByMonth(month);
            return new SuccessDataResult<List<PaymentGetByMonth>>(payments);
        }

        public async Task<IDataResult<decimal>> GetByMonthTotal(int flatId, int month)
        {
            var result = await _repository.GetByMonthTotal(flatId, month);
            return new SuccessDataResult<decimal>(result);
        }

        public async Task<IDataResult<Dictionary<int, decimal>>> GetByMonthTotalWithFlat(int month)
        {
            var result = await _repository.GetByMonthTotalWithFlat(month);
            return new SuccessDataResult<Dictionary<int, decimal>>(result);
        }

        public async Task<IDataResult<List<PaymentGetByYear>>> GetByYear(int year)
        {
            var payments = await _repository.GetByYear(year);
            return new SuccessDataResult<List<PaymentGetByYear>>(payments);
        }

        public async Task<IDataResult<decimal>> GetByYearTotal(int flatId, int year)
        {
            var result = await _repository.GetByYearTotal(flatId, year);
            return new SuccessDataResult<decimal>(result);
        }

        public async Task<IDataResult<Dictionary<int, decimal>>> GetByYearTotalWithFlat(int year)
        {
            var result = await _repository.GetByYearTotalWithFlat(year);
            return new SuccessDataResult<Dictionary<int, decimal>> (result);
        }

        public async Task<IResult> Update(PaymentInformationUpdateDto entity)
        {
            var dto = _mapper.Map<PaymentInformation>(entity);
            await _repository.Update(dto);
            return new SuccessResult();
        }

        public async Task<IDataResult<List<PaymentGetByUser>>> GetByUser(Guid userId)
        {
            var payments = await _repository.GetByUser(userId);
            return new SuccessDataResult<List<PaymentGetByUser>>(payments);
        }

        public async Task<IDataResult<List<PaymentGetByBuilding>>> GetByBuildingNumber(int buildingNumber)
        {
            var buildingWithPayments = await _repository.GetByBuildingNumber(buildingNumber);
            return new SuccessDataResult<List<PaymentGetByBuilding>>(buildingWithPayments);
        }

        public async Task<IDataResult<List<PaymentGetByMonth>>> GetByMonthForUser(int month, Guid userId)
        {
            var results = await _repository.GetByMonthForUser(month, userId);
            return new SuccessDataResult<List<PaymentGetByMonth>>(results);
        }

        public async Task<IDataResult<List<PaymentGetByYear>>> GetByYearForUser(int year, Guid userId)
        {
            var results = await _repository.GetByYearForUser(year, userId);
            return new SuccessDataResult<List<PaymentGetByYear>>(results);
        }

        public async Task<IResult> UserPayInvoice(int entity, string paymendType, Guid userId)
        {
            await _repository.UserPayInvoice(entity, paymendType, userId);
            return new SuccessResult();
        }

    }
}
