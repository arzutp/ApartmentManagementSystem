﻿using ApartmentManagementSystem.Business.Abstract;
using ApartmentManagementSystem.Business.Constants;
using ApartmentManagementSystem.Core.DataAccess;
using ApartmentManagementSystem.Core.Utilities;
using ApartmentManagementSystem.DataAccess.Abstract;
using ApartmentManagementSystem.Entities.DTOs.UserDtos;
using ApartmentManagementSystem.Entities.Entity;
using AutoMapper;
using Azure.Core;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.Business.Concrete
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<Role> _roleManager;
        public UserService(IUserRepository userRepository, IMapper mapper, UserManager<User> userManager, RoleManager<Role> roleManager)
        {
            _userRepository = userRepository;
            _mapper = mapper;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task<IDataResult<Guid>> Add(UserAddDto user)
        {
            var userDto = _mapper.Map<User>(user);
            
            var result = await _userManager.CreateAsync(userDto, user.Password);
            
            if (!result.Succeeded)
            {
                var errorList = result.Errors.Select(x => x.Description).ToList();
                return new ErrorDataResult<Guid>(errorList);
            }
            if (result.Succeeded)
            {
                await _userManager.AddLoginAsync(userDto, new UserLoginInfo("IdentificationNumber", user.IdentificationNumber, null));

                await _userManager.AddLoginAsync(userDto, new UserLoginInfo("PhoneNumber", user.PhoneNumber, null));
            }
            return new SuccessDataResult<Guid>(user.UserName);
        }

        //public async Task<IResult> AddRangeAsync(List<UserAddDto> datas)
        //{
        //    var dto = _mapper.Map<List<User>>(datas);
        //    await _userRepository.AddRangeAsync(dto);
        //    return new SuccessResult();
        //}

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
            var updateUser = await _userManager.FindByIdAsync(user.Id.ToString());
            if (updateUser == null)
            {
                return new ErrorResult(Messages.UserIsInValid);
            }
            updateUser.IdentificationNumber = user.IdentificationNumber;
            updateUser.UserName = user.UserName;
            updateUser.PhoneNumber = user.PhoneNumber;
            updateUser.Name = user.Name;
            updateUser.Surname = user.Surname;
            updateUser.Email = user.Email;
            updateUser.PasswordHash = new PasswordHasher<User>().HashPassword(new User(), user.Password);

            var result =  await _userManager.UpdateAsync(updateUser);
            if (result.Errors.Any())
                return new ErrorResult(result.Errors.ToString());
            return new SuccessResult();
        }
    }
}
