using ApartmentManagementSystem.Core.BaseEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ApartmentManagementSystem.Entities.Entity
{
    public class Flat : IEntity
    {
        public int Id { get; set; }
        public string Block { get; set; } = default!;
        public bool Status { get; set; }
        public string Type { get; set; } = default!;
        public int Floor { get; set; }
        public int FlatNumber { get; set; }

        [ForeignKey("User")]
        public Guid UserId { get; set; }
        public User User { get; set; }

        public List<PaymentInformation> PaymentInformations { get; set; }
    }

}
