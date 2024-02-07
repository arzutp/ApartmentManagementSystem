using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.Entities.DTOs.UserDtos
{
    public class UserUpdateDto : UserBaseWriteDto
    {
        public Guid Id { get; set; }
        public string SecurityStamp { get; set; }
    }
}
