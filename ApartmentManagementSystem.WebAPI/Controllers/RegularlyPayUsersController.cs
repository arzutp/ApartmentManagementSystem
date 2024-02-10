using ApartmentManagementSystem.Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApartmentManagementSystem.WebAPI.Controllers
{
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
    }
}
