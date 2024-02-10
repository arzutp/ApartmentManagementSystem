using ApartmentManagementSystem.Core.BaseEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.Entities.Entity
{
    public class BuildingInvoice : IEntity
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public int BuildingId { get; set; }
        public Building Buildings { get; set; }
        public int InvoiceTypeId { get; set; }
        public InvoiceType InvoiceTypes { get; set; }
    }
}
