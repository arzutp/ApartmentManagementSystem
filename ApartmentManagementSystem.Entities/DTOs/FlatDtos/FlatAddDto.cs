using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.Entities.DTOs.FlatDtos
{
    public class FlatAddDto : FlatBaseWriteDto
    {
        public string Block { get; set; } = default!;
        public bool Status { get; set; }
        public string Type { get; set; } = default!;
        public int Floor { get; set; }
        public int FlatNumber { get; set; }
    }
}
