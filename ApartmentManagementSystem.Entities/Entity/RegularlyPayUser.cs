using ApartmentManagementSystem.Core.BaseEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.Entities.Entity
{
    public class RegularlyPayUser : IEntity
    {
        public int Id { get; set; }
        public int Index { get; set; }
        public int Year { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public int? InvoiceTypeId { get; set; }
        public InvoiceType InvoiceType { get; set; }
    }
}
