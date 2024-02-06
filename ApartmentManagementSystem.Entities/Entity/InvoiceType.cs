using ApartmentManagementSystem.Core.BaseEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.Entities.Entity
{
    public class InvoiceType : IEntity
    {
        //fatura tipleri için = aidat, elektrik, su vb
        public int Id { get; set; }
        public string Name { get; set; } = default!;

        public List<PaymentInformation> PaymentInformations { get; set; }
    } 
}
