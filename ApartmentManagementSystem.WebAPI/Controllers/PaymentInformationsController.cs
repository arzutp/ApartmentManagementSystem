using ApartmentManagementSystem.Business.Abstract;
using ApartmentManagementSystem.Business.Concrete;
using ApartmentManagementSystem.Core.UnitOfWorks;
using ApartmentManagementSystem.Entities.DTOs.InvoiceTypeDtos;
using ApartmentManagementSystem.Entities.DTOs.PaymentInformationDtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace ApartmentManagementSystem.WebAPI.Controllers
{
    //[Authorize(Roles = "Admin")]
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentInformationsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IPaymentInformationService _paymentInformationService;

        public PaymentInformationsController(IPaymentInformationService paymentInformationService, IUnitOfWork unitOfWork)
        {
            _paymentInformationService = paymentInformationService;
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult GetAllPaymentInformations()
        {
            return Ok(_paymentInformationService.GetAll());
        }

        [HttpGet("GetByMonth")]
        public async Task<IActionResult> GetPaymentInformationByMonth(int month)
        {
            var results = await _paymentInformationService.GetByMonth(month);
            return Ok(results);
        }

        [HttpGet("TotalMonthlyUnpaid")]
        public async Task<IActionResult> GetPaymentInformationByMonthTotal(int flatId,int month)
        {
            var results = await _paymentInformationService.GetByMonthTotal(flatId,month);
            return Ok(results.Data);
        }

        [HttpGet("TotalMonthlyUnpaidWithFlat")]
        public async Task<IActionResult> GetMonthWithFlatTotal(int month)
        {
            var results = await _paymentInformationService.GetByMonthTotalWithFlat(month);
            return Ok(results.Data);
        }

        [HttpGet("GetByYear")]
        public async Task<IActionResult> GetPaymentInformationByYear(int year)
        {
            var results = await _paymentInformationService.GetByYear(year);
            return Ok(results);
        }

        [HttpGet("TotalYearlyUnpaid")]
        public async Task<IActionResult> GetPaymentInformationByYearTotal(int flatId, int year)
        {
            var results = await _paymentInformationService.GetByYearTotal(flatId, year);
            return Ok(results.Data);
        }

        [HttpGet("TotalYearlyUnpaidWithFlat")]
        public async Task<IActionResult> GetYearWithFlatTotal(int year)
        {
            var results = await _paymentInformationService.GetByYearTotalWithFlat(year);
            return Ok(results.Data);
        }

        [HttpPost]
        public async Task<IActionResult> AddPaymentInformation(PaymentInformationAddDto paymentInformationAddDto)
        {
            await _paymentInformationService.Add(paymentInformationAddDto);
            await _unitOfWork.CommitAsync();
            return Created();
        }

        [HttpPost("AddList")]
        public async Task<IActionResult> AddRangePaymentInformations(List<PaymentInformationAddDto> paymentInformationAddDto)
        {
            await _paymentInformationService.AddRangeAsync(paymentInformationAddDto);
            await _unitOfWork.CommitAsync();
            return Created();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdPaymentInformation(int id)
        {
            var result = await _paymentInformationService.GetById(id);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdatePaymentInformation(PaymentInformationUpdateDto paymentInformationUpdateDto)
        {
            await _paymentInformationService.Update(paymentInformationUpdateDto);
            await _unitOfWork.CommitAsync();
            return NoContent();
        }

        [HttpDelete]
        public async Task<IActionResult> DeletePaymentInformation(int id)
        {
            await _paymentInformationService.Delete(id);
            _unitOfWork.Commit();
            return NoContent();
        }

        [HttpGet("GetByUser")]
        public async Task<IActionResult> GetByUser(Guid userId)
        {
            var results = await _paymentInformationService.GetByUser(userId);
            return Ok(results);
        }

        [HttpGet("GetByBuilding")]
        public async Task<IActionResult> GetByBuilding(int buildingNumber)
        {
            var results = await _paymentInformationService.GetByBuildingNumber(buildingNumber);
            return Ok(results);
        }

        [HttpGet("ForUser")]
        public async Task<IActionResult> GetByForUser()
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var results = await _paymentInformationService.GetByUser(Guid.Parse(userId));
            return Ok(results);
        }
    }
}
