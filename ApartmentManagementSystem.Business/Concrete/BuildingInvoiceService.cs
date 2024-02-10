using ApartmentManagementSystem.Business.Abstract;
using ApartmentManagementSystem.Core.Utilities;
using ApartmentManagementSystem.DataAccess.Abstract;
using ApartmentManagementSystem.DataAccess.EntityFramework.Repositories;
using ApartmentManagementSystem.Entities.DTOs.BuildingDto;
using ApartmentManagementSystem.Entities.DTOs.BuildingInvoiceDtos;
using ApartmentManagementSystem.Entities.Entity;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.Business.Concrete
{
    public class BuildingInvoiceService : IBuildingInvoiceService
    {
        private readonly IBuildingInvoiceRepository _repository;
        private readonly IMapper _mapper;

        public BuildingInvoiceService(IMapper mapper, IBuildingInvoiceRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<IResult> Add(BuildingInvoiceAddDto entity)
        {
            var dto = _mapper.Map<BuildingInvoice>(entity);
            await _repository.AddAsync(dto);
            return new SuccessResult();
        }

        public async Task<IResult> AddRangeAsync(List<BuildingInvoiceAddDto> datas)
        {
            var dto = _mapper.Map<List<BuildingInvoice>>(datas);
            await _repository.AddRangeAsync(dto);
            return new SuccessResult();
        }

        public IDataResult<List<BuildingInvoiceGetAllDto>> GetAll()
        {
            var data = _repository.GetAll();
            var result = _mapper.Map<List<BuildingInvoiceGetAllDto>>(data);
            return new SuccessDataResult<List<BuildingInvoiceGetAllDto>>(result);
        }
    }
}
