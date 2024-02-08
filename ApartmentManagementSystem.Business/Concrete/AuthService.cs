using ApartmentManagementSystem.Business.Abstract;
using ApartmentManagementSystem.Business.Constants;
using ApartmentManagementSystem.Core.DataAccess;
using ApartmentManagementSystem.Core.Utilities;
using ApartmentManagementSystem.DataAccess.Abstract;
using ApartmentManagementSystem.Entities.DTOs.TokenDtos;
using ApartmentManagementSystem.Entities.DTOs.UserDtos;
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
using ApartmentManagementSystem.Business.Token;

namespace ApartmentManagementSystem.Business.Concrete
{
    public class AuthService : IAuthService
    {
        private readonly IJwtTokenCreate _jwtTokenCreate;
        private readonly UserManager<User> _userManager;
        public AuthService(IJwtTokenCreate jwtTokenCreate, UserManager<User> userManager)
        {
            _jwtTokenCreate = jwtTokenCreate;
            _userManager = userManager;
        }

        public async Task<IDataResult<TokenCreateResponseDto>> Login(AdminTokenCreateRequestDto request)
        {
            var hasUser = await _userManager.FindByNameAsync(request.UserName);
            if(hasUser is null)
            {
                return new ErrorDataResult<TokenCreateResponseDto>(Messages.AuthInvalid);
            }

            var checkPassword = await _userManager.CheckPasswordAsync(hasUser!, request.Password);

            if(checkPassword == false)
            {
                return new ErrorDataResult<TokenCreateResponseDto>(Messages.AuthInvalid);
            }

            var token = _jwtTokenCreate.CreateToken(hasUser);
            return new SuccessDataResult<TokenCreateResponseDto>(token.Result);
        }

        public async Task<IDataResult<TokenCreateResponseDto>> UserLogin(UserTokenCreateRequestDto request)
        {
            var hasUser = await _userManager.FindByLoginAsync("PhoneNumber", request.IdentificationNumberOrPhoneNumber) ??
                          await _userManager.FindByLoginAsync("IdentificationNumber", request.IdentificationNumberOrPhoneNumber);

            if (hasUser == null)
                return new ErrorDataResult<TokenCreateResponseDto>(Messages.AuthInvalid);

            var token = _jwtTokenCreate.CreateToken(hasUser);

            return new SuccessDataResult<TokenCreateResponseDto>(token.Result);
        }

        
    }
}
