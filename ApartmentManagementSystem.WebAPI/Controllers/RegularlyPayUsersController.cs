using ApartmentManagementSystem.Business.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApartmentManagementSystem.WebAPI.Controllers
{
    [Authorize(Roles = "Admin")]
    [Route("api/[controller]")]
    [ApiController]
    public class RegularlyPayUsersController : ControllerBase
    {
        private readonly IRegularlyPayUserService _userService;

        public RegularlyPayUsersController(IRegularlyPayUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult GetRegularlyPayUsers(int index)
        {
            var results = _userService.RegularlyPayUserWithIndex(index);
            return Ok(results);
        }

        [HttpGet("WithYear")]
        public IActionResult RegularlyPayUserGetByYear(int year, string name, int index)
        {
            var results = _userService.RegularlyPayUserGetByYear(year,name,index);
            return Ok(results);
        }
    }
}
