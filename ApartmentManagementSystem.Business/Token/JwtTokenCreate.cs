using ApartmentManagementSystem.Entities.DTOs.TokenDtos;
using ApartmentManagementSystem.Entities.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.Business.Token
{
    public class JwtTokenCreate : IJwtTokenCreate
    {
        private readonly IConfiguration _configuration;
        private readonly UserManager<User> _userManager;
        public JwtTokenCreate(IConfiguration configuration, UserManager<User> userManager)
        {
            _configuration = configuration;
            _userManager = userManager;
        }

        public async Task<TokenCreateResponseDto> CreateToken(User hasUser)
        {
            var signatureKey = _configuration.GetSection("TokenOptions")["SignatureKey"]!;
            var tokenExpireAsHour = _configuration.GetSection("TokenOptions")["Expire"]!;

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(signatureKey));
            SigningCredentials signingCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature);

            var claimList = new List<Claim>();

            var userIdAsClaim = new Claim(ClaimTypes.NameIdentifier, hasUser.Id.ToString());
            var userNameAsClaim = new Claim(ClaimTypes.Name, hasUser.Surname!);
            var idAsClaim = new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString());

            var userClaims = await _userManager.GetClaimsAsync(hasUser);

            foreach (var claim in userClaims)
            {
                claimList.Add(new Claim(claim.Type, claim.Value));
            }

            claimList.Add(userIdAsClaim);
            claimList.Add(userNameAsClaim);
            claimList.Add(idAsClaim);

            foreach (var role in await _userManager.GetRolesAsync(hasUser))
            {
                claimList.Add(new Claim(ClaimTypes.Role, role));
            }

            var token = new JwtSecurityToken(
                expires: DateTime.Now.AddHours(Convert.ToDouble(tokenExpireAsHour)),
                signingCredentials: signingCredentials,
                claims: claimList
            );
            var responseDto = new TokenCreateResponseDto
            {
                Token = new JwtSecurityTokenHandler().WriteToken(token),
            };

            return responseDto;
        }
    }
}
