using ApartmentManagementSystem.Business.Abstract;
using ApartmentManagementSystem.Business.Concrete;
using ApartmentManagementSystem.Core.UnitOfWorks;
using ApartmentManagementSystem.Entities.DTOs.InvoiceTypeDtos;
using ApartmentManagementSystem.Entities.DTOs.PaymentInformationDtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApartmentManagementSystem.WebAPI.Controllers
{
    [Authorize(Roles = "Admin")]
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
    }
}
