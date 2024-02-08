using ApartmentManagementSystem.Core.Utilities;
using ApartmentManagementSystem.Entities.DTOs.TokenDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.Business.Abstract
{
    public interface IAuthService
    {
        Task<IDataResult<TokenCreateResponseDto>> Login(AdminTokenCreateRequestDto request);
        Task<IDataResult<TokenCreateResponseDto>> UserLogin(UserTokenCreateRequestDto request);
    }
}
