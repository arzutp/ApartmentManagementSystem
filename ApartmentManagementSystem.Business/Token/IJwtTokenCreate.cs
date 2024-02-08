using ApartmentManagementSystem.Entities.DTOs.TokenDtos;
using ApartmentManagementSystem.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.Business.Token
{
    public interface IJwtTokenCreate
    {
        Task<TokenCreateResponseDto> CreateToken(User hasUser);
    }
}
