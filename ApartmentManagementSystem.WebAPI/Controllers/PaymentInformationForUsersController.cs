using ApartmentManagementSystem.Business.Abstract;
using ApartmentManagementSystem.Core.UnitOfWorks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace ApartmentManagementSystem.WebAPI.Controllers
{
    [Authorize(Roles = "Kiracı")]
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentInformationForUsersController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IPaymentInformationService _paymentInformationService;

        public PaymentInformationForUsersController(IPaymentInformationService paymentInformationService, IUnitOfWork unitOfWork)
        {
            _paymentInformationService = paymentInformationService;
            _unitOfWork = unitOfWork;
        }

        [HttpGet("ForUser")]
        public async Task<IActionResult> GetByForUser()
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (userId == null)
                return BadRequest();
            var results = await _paymentInformationService.GetByUser(Guid.Parse(userId));

            return Ok(results);
        }

        [HttpGet("MonthlyForUser")]
        public async Task<IActionResult> GetByMonthForUser(int month)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (userId == null)
                return BadRequest();
            var results = await _paymentInformationService.GetByMonthForUser(month, Guid.Parse(userId));
            return Ok(results);
        }

        [HttpGet("YearlyForUser")]
        public async Task<IActionResult> GetByYearForUser(int year)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (userId == null)
                return BadRequest();
            var results = await _paymentInformationService.GetByYearForUser(year, Guid.Parse(userId));
            return Ok(results);
        }

        [HttpGet("UserPayInvoice")]
        public async Task<IActionResult> UserPayInvoice(int id, string paymentType)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (userId == null)
                return BadRequest();
            var result = await _paymentInformationService.UserPayInvoice(id, paymentType, Guid.Parse(userId));
            await _unitOfWork.CommitAsync();
            return Ok(result);
        }
    }
}
