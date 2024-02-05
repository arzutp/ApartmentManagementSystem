using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.Entities.DTOs.PaymentTypeDtos
{
    public class PaymentTypeReadDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
    }
}
