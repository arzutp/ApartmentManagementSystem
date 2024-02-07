using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.Entities.DTOs.FlatDtos
{
    public class FlatPaymentAddDto 
    {
        public int Id { get; set; }
        public bool IsPayed { get; set; }
        public decimal Price { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int InvoiceTypeId { get; set; }
    }
}
