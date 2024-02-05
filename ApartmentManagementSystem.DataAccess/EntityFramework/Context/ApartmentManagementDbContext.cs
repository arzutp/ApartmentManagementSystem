using ApartmentManagementSystem.Entities.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.DataAccess.EntityFramework.Context
{
    public class ApartmentManagementDbContext : IdentityDbContext<User, Role, Guid>
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
                .OnDelete(DeleteBehavior.NoAction); //ana tablodan bir kayıt silindiğinde diğer tabloda ki kayıtların silinmesini de engellemek için

            //admin add
            var adminUserId = Guid.NewGuid();
            var adminRoleId = Guid.NewGuid();
            builder.Entity<Role>().HasData(
                new Role
                {
                    Id = adminRoleId,
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                }
            );

            builder.Entity<User>().HasData(
                new User
                {
                    Id = adminUserId,
                    IdentificationNumber = "11111111111",
                    Name = "Admin",
                    Surname = "ADMIN",
                    UserName = "admin",
                    NormalizedUserName = "ADMIN",
                    Email = "admin@admin.com",
                    EmailConfirmed = true,
                    NormalizedEmail = "ADMIN@ADMIN.com",
                    PasswordHash = new PasswordHasher<User>().HashPassword(new User(), "123456")
                }
            );

            
            builder.Entity<IdentityUserRole<Guid>>().HasData(
                new IdentityUserRole<Guid>
                {
                    UserId = adminUserId,
                    RoleId = adminRoleId
                }
            );
            base.OnModelCreating(builder);
            
        }
    }
}
