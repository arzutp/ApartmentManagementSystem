using ApartmentManagementSystem.Business.Abstract;
using ApartmentManagementSystem.Core.Utilities;
using ApartmentManagementSystem.DataAccess.Abstract;
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

        public Task<IResult> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<UserGetAllDto>> GetAll()
        {
            var users = _userRepository.GetAll();
            var result = _mapper.Map<List<UserGetAllDto>>(users);
            return new SuccessDataResult<List<UserGetAllDto>>(result);
        }

        public Task<IDataResult<UserGetByIdDto>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(UserUpdateDto user)
        {
            throw new NotImplementedException();
        }
    }
}
