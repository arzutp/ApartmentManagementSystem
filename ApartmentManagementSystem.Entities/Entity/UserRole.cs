using ApartmentManagementSystem.Core.BaseEntity;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.Entities.Entity
{
    public class UserRole : IdentityRole<Guid>, IEntity
    {
    }
}
