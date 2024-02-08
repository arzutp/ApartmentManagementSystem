using ApartmentManagementSystem.Business.Abstract;
using ApartmentManagementSystem.Business.Concrete;
using ApartmentManagementSystem.Entities.DTOs.TokenDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApartmentManagementSystem.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateTokenForAdmin(AdminTokenCreateRequestDto request)
        {
            var response = await _authService.Login(request);
            if (!response.IsSuccess)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }

        [HttpPost("User")]
        public async Task<IActionResult> CreateTokenForUser(UserTokenCreateRequestDto request)
        {
            var response = await _authService.UserLogin(request);
            if (!response.IsSuccess)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }
    }
}
