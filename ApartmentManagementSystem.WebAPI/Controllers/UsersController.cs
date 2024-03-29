﻿using ApartmentManagementSystem.Business.Abstract;
using ApartmentManagementSystem.Business.Concrete;
using ApartmentManagementSystem.Core.UnitOfWorks;
using ApartmentManagementSystem.Entities.DTOs.UserDtos;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApartmentManagementSystem.WebAPI.Controllers
{
    [Authorize(Roles = "Admin")]
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IUnitOfWork _unitOfWork;

        public UsersController(IUnitOfWork unitOfWork, IUserService userService)
        {
            _unitOfWork = unitOfWork;
            _userService = userService;
        }

        
        [HttpGet]
        public IActionResult GetAllUsers()
        {
            return Ok(_userService.GetAll());
        }

        [HttpPost]
        public async Task<IActionResult> AddUser(UserAddDto userAddDto)
        {
            var response = await _userService.Add(userAddDto);
            if(!response.IsSuccess)
            {
                return BadRequest(response);
            }
            await _unitOfWork.CommitAsync();
            return Created();
        }

        //[HttpPost("AddList")]
        //public async Task<IActionResult> AddRangeUsers(List<UserAddDto> userAddDto)
        //{
        //    await _userService.AddRangeAsync(userAddDto);
        //    await _unitOfWork.CommitAsync();
        //    return Created();
        //}

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdUser(Guid id)
        {
            var result = await _userService.GetById(id);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateUser(UserUpdateDto userUpdateDto)
        {
            var result = await _userService.Update(userUpdateDto);
            if(!result.IsSuccess)
            {
                return BadRequest();
            }
            await _unitOfWork.CommitAsync();
            return NoContent();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteUser(Guid id)
        {
            await _userService.Delete(id);
            _unitOfWork.Commit();
            return NoContent();
        }
    }
}
