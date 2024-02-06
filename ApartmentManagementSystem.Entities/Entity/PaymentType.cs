using ApartmentManagementSystem.Core.BaseEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.Entities.Entity
{
    public class PaymentType : IEntity
    {
        //kredi kartı - nakit tipi için
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        //public List<PaymentInformation> PaymentInformations { get; set; }
    }
}
