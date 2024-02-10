using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.Entities.DTOs.RegularlyPayUserDto
{
    public class RegularlyPayUserReadDto
    {
        public int Id { get; set; }
        public int Index { get; set; }
        public Guid UserId { get; set; }
        public int InvoiceTypeId { get; set; }
    }
}
