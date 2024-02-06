using ApartmentManagementSystem.Business.Abstract;
using ApartmentManagementSystem.Core.BaseEntity;
using ApartmentManagementSystem.Core.DataAccess;
using ApartmentManagementSystem.Core.Utilities;
using ApartmentManagementSystem.DataAccess.Abstract;
using ApartmentManagementSystem.Entities.DTOs.InvoiceTypeDtos;
using ApartmentManagementSystem.Entities.DTOs.PaymentInformationDtos;
using ApartmentManagementSystem.Entities.Entity;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.Business.Concrete
{
    public class InvoiceTypeService : IInvoiceTypeService
    {
        private readonly IInvoiceTypeRepository _repository;
        private readonly IMapper _mapper;

        public InvoiceTypeService(IInvoiceTypeRepository invoiceTypeRepository, IMapper mapper)
        {
            _repository = invoiceTypeRepository;
            _mapper = mapper;
        }
       
        public async Task<IResult> Add(InvoiceTypeAddDto entity)
        {
            var dto = _mapper.Map<InvoiceType>(entity);
            await _repository.AddAsync(dto);
            return new SuccessResult();
        }

        public async Task<IResult> AddRangeAsync(List<InvoiceTypeAddDto> datas)
        {
            var dto = _mapper.Map<List<InvoiceType>>(datas);
            await _repository.AddRangeAsync(dto);
            return new SuccessResult();
        }

        public async Task<IResult> Delete(int id)
        {
            await _repository.DeleteAsync(id);
            return new SuccessResult();
        }

        public IDataResult<List<InvoiceTypeGetAllDto>> GetAll()
        {
            var data = _repository.GetAll();
            var result = _mapper.Map<List<InvoiceTypeGetAllDto>>(data);
            return new SuccessDataResult<List<InvoiceTypeGetAllDto>>(result);
        }

        public async Task<IDataResult<InvoiceTypeGetByIdDto>> GetById(int id)
        {
            var data = await _repository.GetById(id);
            var result = _mapper.Map<InvoiceTypeGetByIdDto>(data);
            return new SuccessDataResult<InvoiceTypeGetByIdDto>(result);
        }

        public async Task<IResult> Update(InvoiceTypeUpdateDto entity)
        {
            var dto = _mapper.Map<InvoiceType>(entity);
            await _repository.Update(dto);
            return new SuccessResult();
        }
    }
}
