using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.Entities.DTOs.BuildingInvoiceDtos
{
    public class BuildingInvoiceWriteDto
    {
        public int Price { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public int BuildingId { get; set; }
        public int InvoiceTypeId { get; set; }
    }
}
