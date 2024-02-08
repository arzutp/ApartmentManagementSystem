using ApartmentManagementSystem.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.Entities.DTOs.PaymentInformationDtos
{
    public class PaymentGetByBuilding : PaymentInformationBaseReadDto
    {
        public string InvoiceType { get; set; }
        public int FlatNumber { get; set; }
        public string BuildingName { get; set; }
        public int BuildingNumber { get; set; }
        public List<Flat> Flats { get; set; }
    }
}
