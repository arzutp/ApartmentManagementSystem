using ApartmentManagementSystem.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.Entities.DTOs.UserDtos
{
    public class UserGetPaymentDto : UserBaseReadDto
    {
        public bool IsPayed { get; set; }
        public DateTime? DateOfPayment { get; set; } = null;
        public decimal Price { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public string? PaymentType { get; set; } = null;
        public int? InvoiceTypeId { get; set; }

    }
}
