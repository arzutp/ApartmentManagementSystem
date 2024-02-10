using ApartmentManagementSystem.Business.Abstract;
using ApartmentManagementSystem.Business.Concrete;
using ApartmentManagementSystem.Core.UnitOfWorks;
using ApartmentManagementSystem.Entities.DTOs.BuildingDto;
using ApartmentManagementSystem.Entities.DTOs.InvoiceTypeDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApartmentManagementSystem.WebAPI.Controllers
{
    //[Authorize(Roles = "Admin")]
    [Route("api/[controller]")]
    [ApiController]
    public class BuildingsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IBuildingService _buildingService;

        public BuildingsController(IBuildingService buildingService, IUnitOfWork unitOfWork)
        {
            _buildingService = buildingService;
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult GetAllBuildings() => Ok(_buildingService.GetAll());


        [HttpPost]
        public async Task<IActionResult> AddBuilding(BuildingAddDto addDto)
        {
            await _buildingService.Add(addDto);
            await _unitOfWork.CommitAsync();
            return Created();
        }

        [HttpPost("AddList")]
        public async Task<IActionResult> AddRangeBuildings(List<BuildingAddDto> addDto)
        {
            await _buildingService.AddRangeAsync(addDto);
            await _unitOfWork.CommitAsync();
            return Created();
        }
    }
}
