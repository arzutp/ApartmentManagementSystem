﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.Entities.DTOs.PaymentInformationDtos
{
    public class PaymentInformationUpdateDto : PaymentInformationBaseWriteDto
    {
        public int Id { get; set; }
    }
}
