﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.Entities.DTOs.PaymentInformationDtos
{
    public class PaymentInformationBaseWriteDto
    {
        public bool IsPayed { get; set; }
        public DateTime? DateOfPayment { get; set; }
        public decimal Price { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int InvoiceTypeId { get; set; }
        public int FlatId { get; set; }
        public Guid? UserId { get; set; }
        public string? PaymentType { get; set; }
    }
}
