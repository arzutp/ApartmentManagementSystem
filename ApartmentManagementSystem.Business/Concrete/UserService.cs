using ApartmentManagementSystem.Business.Abstract;
using ApartmentManagementSystem.Core.DataAccess;
using ApartmentManagementSystem.Core.Utilities;
using ApartmentManagementSystem.DataAccess.Abstract;
using ApartmentManagementSystem.Entities.DTOs.UserDtos;
using ApartmentManagementSystem.Entities.Entity;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.Business.Concrete
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<IResult> Add(UserAddDto user)
        {
            var userDto = _mapper.Map<User>(user);
            await _userRepository.AddAsync(userDto);
            return new SuccessResult();
        }

        public async Task<IResult> AddRangeAsync(List<UserAddDto> datas)
        {
            var dto = _mapper.Map<List<User>>(datas);
            await _userRepository.AddRangeAsync(dto);
            return new SuccessResult();
        }

        public async Task<IResult> Delete(Guid id)
        {
            await _userRepository.DeleteAsync(id);
            return new SuccessResult();
        }

        public IDataResult<List<UserGetAllDto>> GetAll()
        {
            var users = _userRepository.GetAll();
            var result = _mapper.Map<List<UserGetAllDto>>(users);
            return new SuccessDataResult<List<UserGetAllDto>>(result);
        }

        public async Task<IDataResult<UserGetByIdDto>> GetById(Guid id)
        {
            var user = await _userRepository.GetById(id);
            var result = _mapper.Map<UserGetByIdDto>(user);
            return new SuccessDataResult<UserGetByIdDto>(result);
        }

        public async Task<IResult> Update(UserUpdateDto user)
        {

            var userDto = _mapper.Map<User>(user);
            await _userRepository.Update(userDto);
            return new SuccessResult();
        }
    }
}
