using ApartmentManagementSystem.Business.Abstract;
using ApartmentManagementSystem.Core.Utilities;
using ApartmentManagementSystem.DataAccess.Abstract;
using ApartmentManagementSystem.DataAccess.EntityFramework.Repositories;
using ApartmentManagementSystem.Entities.DTOs.FlatDtos;
using ApartmentManagementSystem.Entities.DTOs.UserDtos;
using ApartmentManagementSystem.Entities.Entity;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.Business.Concrete
{
    public class FlatService : IFlatService
    {
        private readonly IFlatRepository _flatRepository;
        private readonly IMapper _mapper;

        public FlatService(IMapper mapper, IFlatRepository flatRepository)
        {
            _mapper = mapper;
            _flatRepository = flatRepository;
        }

        public async Task<IResult> Add(FlatAddDto entity)
        {
            var flatDto = _mapper.Map<Flat>(entity);
            await _flatRepository.AddAsync(flatDto);
            return new SuccessResult();
        }

        public async Task<IResult> Delete(int id)
        {
            await _flatRepository.DeleteAsync(id);
            return new SuccessResult();
        }

        public IDataResult<List<FlatGetAllDto>> GetAll()
        {
            var flats = _flatRepository.GetAll();
            var result = _mapper.Map<List<FlatGetAllDto>>(flats);
            return new SuccessDataResult<List<FlatGetAllDto>>(result);
        }

        public async Task<IDataResult<FlatGetByIdDto>> GetById(int id)
        {
            var flat = await _flatRepository.GetById(id);
            var result = _mapper.Map<FlatGetByIdDto>(flat);
            return new SuccessDataResult<FlatGetByIdDto>(result);
        }

        public async Task<IResult> Update(FlatUpdateDto entity)
        {
            var flatDto = _mapper.Map<Flat>(entity);
            await _flatRepository.Update(flatDto);
            return new SuccessResult();
        }
    }
}
