using ApartmentManagementSystem.Business.Abstract;
using ApartmentManagementSystem.Business.Concrete;
using ApartmentManagementSystem.Core.UnitOfWorks;
using ApartmentManagementSystem.Entities.DTOs.BuildingDto;
using ApartmentManagementSystem.Entities.DTOs.BuildingInvoiceDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApartmentManagementSystem.WebAPI.Controllers
{
    //[Authorize(Roles = "Admin")]
    [Route("api/[controller]")]
    [ApiController]
    public class BuildingInvoicesController : ControllerBase
    {
        private readonly IBuildingInvoiceService _buildingInvoiceService;
        private readonly IUnitOfWork _unitOfWork;

        public BuildingInvoicesController(IUnitOfWork unitOfWork, IBuildingInvoiceService buildingInvoiceService)
        {
            _unitOfWork = unitOfWork;
            _buildingInvoiceService = buildingInvoiceService;
        }

        [HttpGet]
        public IActionResult GetAllBuildingInvoices() => Ok(_buildingInvoiceService.GetAll());


        [HttpPost]
        public async Task<IActionResult> AddBuildingInvoice(BuildingInvoiceAddDto addDto)
        {
            await _buildingInvoiceService.Add(addDto);
            await _unitOfWork.CommitAsync();
            return Created();
        }

        [HttpPost("AddList")]
        public async Task<IActionResult> AddRangeBuildingInvoices(List<BuildingInvoiceAddDto> addDto)
        {
            await _buildingInvoiceService.AddRangeAsync(addDto);
            await _unitOfWork.CommitAsync();
            return Created();
        }

    }
}
