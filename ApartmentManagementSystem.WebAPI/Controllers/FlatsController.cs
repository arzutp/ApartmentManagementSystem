﻿using ApartmentManagementSystem.Business.Abstract;
using ApartmentManagementSystem.Business.Concrete;
using ApartmentManagementSystem.Core.UnitOfWorks;
using ApartmentManagementSystem.Entities.DTOs.FlatDtos;
using ApartmentManagementSystem.Entities.DTOs.UserDtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApartmentManagementSystem.WebAPI.Controllers
{
    [Authorize(Roles = "Admin")]
    [Route("api/[controller]")]
    [ApiController]
    public class FlatsController : ControllerBase
    {
        private readonly IFlatService _flatService;
        private readonly IUnitOfWork _unitOfWork;

        public FlatsController(IUnitOfWork unitOfWork, IFlatService flatService)
        {
            _unitOfWork = unitOfWork;
            _flatService = flatService;
        }

        [HttpGet]
        public IActionResult GetAllFlats()
        {
            return Ok(_flatService.GetAll());
        }

        [HttpGet("FlatWithPayed")]
        public IActionResult PayedInvoice() => Ok(_flatService.PayedGetAllDto());

        [HttpGet("FlatsWithUsers")]
        public IActionResult GetAllWithUsers() {
            return Ok(_flatService.GetAllWithUsers());
        }

        [HttpPost]
        public async Task<IActionResult> AddFlats(FlatAddDto flatAddDto)
        {
            await _flatService.Add(flatAddDto);
            await _unitOfWork.CommitAsync();
            return Created();
        }

        [HttpPut("AddOwner")]
        public async Task<IActionResult> FlatAddUser(FlatUserAddDto flatUserAddDto)
        {
            var response = await _flatService.FlatAddUser(flatUserAddDto);
            if(!response.IsSuccess)
            {
                return BadRequest(response);
            }
            _unitOfWork.Commit();
            return Ok();
        }

        [HttpPut("FlatPayment")]
        public async Task<IActionResult> FlatPaymentAdd(FlatPaymentAddDto flatPaymentAddDto)
        {
            var response = await _flatService.FlatPaymentAdd(flatPaymentAddDto);
            if (!response.IsSuccess)
            {
                return BadRequest(response);
            }
            _unitOfWork.Commit();
            return Ok();
        }

        [HttpPost("AddList")]
        public async Task<IActionResult> AddRangeFlats(List<FlatAddDto> flatAddDto)
        {
            await _flatService.AddRangeAsync(flatAddDto);
            await _unitOfWork.CommitAsync();
            return Created();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdFlat(int id)
        {
            var result = await _flatService.GetById(id);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateFlat(FlatUpdateDto flatUpdateDto)
        {
            await _flatService.Update(flatUpdateDto);
            await _unitOfWork.CommitAsync();
            return NoContent();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteFlat(int id)
        {
            await _flatService.Delete(id);
            _unitOfWork.Commit();
            return NoContent();
        }

    }
}
