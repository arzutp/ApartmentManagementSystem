using ApartmentManagementSystem.Business.Abstract;
using ApartmentManagementSystem.Business.Constants;
using ApartmentManagementSystem.Core.Utilities;
using ApartmentManagementSystem.DataAccess.Abstract;
using ApartmentManagementSystem.DataAccess.EntityFramework.Repositories;
using ApartmentManagementSystem.Entities.DTOs.FlatDtos;
using ApartmentManagementSystem.Entities.DTOs.UserDtos;
using ApartmentManagementSystem.Entities.Entity;
using AutoMapper;
using Microsoft.Extensions.Caching.Memory;
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
        private readonly IMemoryCache _memoryCache;
        public FlatService(IMapper mapper, IFlatRepository flatRepository, IMemoryCache memoryCache)
        {
            _mapper = mapper;
            _flatRepository = flatRepository;
            _memoryCache = memoryCache;
        }

        public async Task<IResult> Add(FlatAddDto entity)
        {
            string key = "Flats";
            _memoryCache.Remove(key);
            var flatDto = _mapper.Map<Flat>(entity);
            await _flatRepository.AddAsync(flatDto);
            return new SuccessResult();
        }

        public async Task<IResult> AddRangeAsync(List<FlatAddDto> datas)
        {
            string key = "Flats";
            _memoryCache.Remove(key);
            var flatDtos = _mapper.Map<List<Flat>>(datas);
            await _flatRepository.AddRangeAsync(flatDtos);
            return new SuccessResult();
        }

        public async Task<IResult> Delete(int id)
        {
            string key = "Flats";
            _memoryCache.Remove(key);
            await _flatRepository.DeleteAsync(id);
            return new SuccessResult();
        }

        public async Task<IResult> FlatAddUser(FlatUserAddDto flatUserAddDto)
        {
            var flatDto = _mapper.Map<Flat>(flatUserAddDto);
            var result = await _flatRepository.AddFlatOwner(flatDto);
            if (!result)
            {
                return new ErrorResult(Messages.AlreadyAssigned);
            }
            return new SuccessResult();
        }

        public async Task<IResult> FlatPaymentAdd(FlatPaymentAddDto entity)
        {
            
            var result = await _flatRepository.FlatPaymentAdd(entity);
            if (!result)
            {
                return new ErrorResult();
            }
            return new SuccessResult();
        }

        public IDataResult<List<FlatGetAllDto>> GetAll()
        {
            string key = "Flats";
            if(_memoryCache.TryGetValue(key, out List<FlatGetAllDto>? data))
            {
                return new SuccessDataResult<List<FlatGetAllDto>>(data!);
            }
            var flats = _flatRepository.GetAll();
            var result = _mapper.Map<List<FlatGetAllDto>>(flats);
            _memoryCache.Set(key, result, TimeSpan.FromHours(1));
            return new SuccessDataResult<List<FlatGetAllDto>>(result);
        }

        public IDataResult<List<FlatGetAllWithUsers>> GetAllWithUsers()
        {
            var flatsWithUsers = _flatRepository.GetAllWithUsers();
            var result = _mapper.Map<List<FlatGetAllWithUsers>>(flatsWithUsers);
            return new SuccessDataResult<List<FlatGetAllWithUsers>>(result);
        }

        public async Task<IDataResult<FlatGetByIdDto>> GetById(int id)
        {
            var flat = await _flatRepository.GetById(id);
            var result = _mapper.Map<FlatGetByIdDto>(flat);
            return new SuccessDataResult<FlatGetByIdDto>(result);
        }

        public IDataResult<List<FlatPaymentGetAllDto>> PayedGetAllDto()
        {
            var flatWithPayed = _flatRepository.PayedGetAllDto();
            return new SuccessDataResult<List<FlatPaymentGetAllDto>>(flatWithPayed);
        }

        public async Task<IResult> Update(FlatUpdateDto entity)
        {
            string key = "Flats";
            _memoryCache.Remove(key);
            var flatDto = _mapper.Map<Flat>(entity);
            await _flatRepository.Update(flatDto);
            return new SuccessResult();
        }
    }
}
