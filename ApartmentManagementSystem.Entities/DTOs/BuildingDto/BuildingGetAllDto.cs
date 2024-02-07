using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.Entities.DTOs.BuildingDto
{
    public class BuildingGetAllDto
    {
        public int Id { get; set; }
        public string BuildingName { get; set; }
        public int BuildingNumber { get; set; }
    }
}
