using ApartmentManagementSystem.Core.BaseEntity;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.Entities.Entity
{
    public class User : IdentityUser<Guid>, IEntity
    {
        public string IdentificationNumber { get; set; } = default!;
        public string Name { get; set; } = default!;
        public string Surname { get; set; } = default!;

        public Flat Flat { get; set; }
        public List<PaymentInformation> PaymentInformations { get; set; }
    }
}
