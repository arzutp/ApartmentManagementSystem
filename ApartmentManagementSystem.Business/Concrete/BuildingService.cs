using ApartmentManagementSystem.Business.Abstract;
using ApartmentManagementSystem.Core.DataAccess;
using ApartmentManagementSystem.Core.Utilities;
using ApartmentManagementSystem.DataAccess.Abstract;
using ApartmentManagementSystem.Entities.DTOs.BuildingDto;
using ApartmentManagementSystem.Entities.DTOs.InvoiceTypeDtos;
using ApartmentManagementSystem.Entities.Entity;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.Business.Concrete
{
    public class BuildingService : IBuildingService
    {
        private readonly IMapper _mapper;
        private readonly IBuildingRepository _buildingRepository;

        public BuildingService(IBuildingRepository buildingRepository, IMapper mapper)
        {
            _buildingRepository = buildingRepository;
            _mapper = mapper;
        }

        public async Task<IResult> Add(BuildingAddDto entity)
        {
            var dto = _mapper.Map<Building>(entity);
            await _buildingRepository.AddAsync(dto);
            return new SuccessResult();
        }

        public async Task<IResult> AddRangeAsync(List<BuildingAddDto> datas)
        {
            var dto = _mapper.Map<List<Building>>(datas);
            await _buildingRepository.AddRangeAsync(dto);
            return new SuccessResult();
        }

        public IDataResult<List<BuildingGetAllDto>> GetAll()
        {
            var data = _buildingRepository.GetAll();
            var result = _mapper.Map<List<BuildingGetAllDto>>(data);
            return new SuccessDataResult<List<BuildingGetAllDto>>(result);
        }
    }
}
