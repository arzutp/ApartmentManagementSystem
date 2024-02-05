using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.Entities.DTOs.InvoiceTypeDtos
{
    public class InvoiceTypeReadDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
    }
}
