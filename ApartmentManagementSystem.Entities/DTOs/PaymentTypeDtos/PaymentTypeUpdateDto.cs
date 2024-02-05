
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.Entities.DTOs.PaymentTypeDtos
{
    public class PaymentTypeUpdateDto : PaymentTypeWriteDto
    {
        public int Id { get; set; }
    }
}
