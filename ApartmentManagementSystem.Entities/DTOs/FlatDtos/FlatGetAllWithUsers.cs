using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.Entities.DTOs.FlatDtos
{
    public class FlatGetAllWithUsers : FlatBaseReadDto
    {
        public string IdentificationNumber { get; set; } = default!;
        public string Name { get; set; } = default!;
        public string Surname { get; set; } = default!;
        public string PhoneNumber { get; set; }
    }
}
