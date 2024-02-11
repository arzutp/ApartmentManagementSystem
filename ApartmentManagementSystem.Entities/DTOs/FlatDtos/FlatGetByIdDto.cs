﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.Entities.DTOs.FlatDtos
{
    public class FlatGetByIdDto : FlatBaseReadDto
    {
        public int BuildingId { get; set; }
        public Guid UserId { get; set; }
    }
}
