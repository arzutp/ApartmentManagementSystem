using ApartmentManagementSystem.Entities.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.DataAccess.EntityFramework.Context
{
    public class ApartmentManagementDbContext : IdentityDbContext<User, UserRole, Guid>
    {
        public ApartmentManagementDbContext(DbContextOptions<ApartmentManagementDbContext> options) : base(options)
        {
        }

        public DbSet<Flat> Flats { get; set; }
        public DbSet<InvoiceType> InvoiceTypes { get; set; }
        public DbSet<PaymentType> PaymentTypes { get; set; }
        public DbSet<PaymentInformation> PaymentInformations { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Flat>()
                .HasMany(f=>f.PaymentInformations)
                .WithOne(p=>p.Flat)
                .HasForeignKey(p=>p.FlatId)
                .OnDelete(DeleteBehavior.NoAction); //ana tablodan bir kayıt silidiğinde diğer tabloda ki kayıtların silinmesini de engellemek için


            base.OnModelCreating(builder);
            
        }
    }
}
