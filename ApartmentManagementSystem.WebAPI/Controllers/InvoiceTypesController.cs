using ApartmentManagementSystem.Business.Abstract;
using ApartmentManagementSystem.Business.Concrete;
using ApartmentManagementSystem.Core.UnitOfWorks;
using ApartmentManagementSystem.Entities.DTOs.FlatDtos;
using ApartmentManagementSystem.Entities.DTOs.InvoiceTypeDtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApartmentManagementSystem.WebAPI.Controllers
{
    [Authorize(Roles = "Admin")]
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceTypesController : ControllerBase
    {
        private readonly IInvoiceTypeService _invoiceTypeService;
        private readonly IUnitOfWork _unitOfWork;

        public InvoiceTypesController(IUnitOfWork unitOfWork, IInvoiceTypeService invoiceTypeService)
        {
            _unitOfWork = unitOfWork;
            _invoiceTypeService = invoiceTypeService;
        }

        [HttpGet]
        public IActionResult GetAllInvoiceTypes()
        {
            return Ok(_invoiceTypeService.GetAll());
        }

        [HttpPost]
        public async Task<IActionResult> AddInvoiceType(InvoiceTypeAddDto invoiceTypeAddDto)
        {
            await _invoiceTypeService.Add(invoiceTypeAddDto);
            await _unitOfWork.CommitAsync();
            return Created();
        }

        [HttpPost("AddList")]
        public async Task<IActionResult> AddRangeInvoiceTypes(List<InvoiceTypeAddDto> invoiceTypeAddDto)
        {
            await _invoiceTypeService.AddRangeAsync(invoiceTypeAddDto);
            await _unitOfWork.CommitAsync();
            return Created();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdInvoiceType(int id)
        {
            var result = await _invoiceTypeService.GetById(id);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateInvoiceType(InvoiceTypeUpdateDto invoiceTypeUpdateDto)
        {
            await _invoiceTypeService.Update(invoiceTypeUpdateDto);
            await _unitOfWork.CommitAsync();
            return NoContent();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteInvoiceType(int id)
        {
            await _invoiceTypeService.Delete(id);
            _unitOfWork.Commit();
            return NoContent();
        }
    }
}
