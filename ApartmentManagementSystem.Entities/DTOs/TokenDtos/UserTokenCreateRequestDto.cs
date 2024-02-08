using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.Entities.DTOs.TokenDtos
{
    public class UserTokenCreateRequestDto
    {
        public string IdentificationNumberOrPhoneNumber { get; set; }
    }
}
