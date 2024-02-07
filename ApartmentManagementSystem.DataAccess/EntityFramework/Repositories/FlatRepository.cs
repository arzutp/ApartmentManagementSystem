using ApartmentManagementSystem.DataAccess.Abstract;
using ApartmentManagementSystem.DataAccess.EntityFramework.Context;
using ApartmentManagementSystem.Entities.DTOs.FlatDtos;
using ApartmentManagementSystem.Entities.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.DataAccess.EntityFramework.Repositories
{
    public class FlatRepository : BaseRepository<Flat>, IFlatRepository
    {
        public FlatRepository(ApartmentManagementDbContext context) : base(context)
        {
        }

        public async Task<bool> AddFlatOwner(Flat entity)
        {
            var isFlatInUser = await _context.Set<Flat>().Include(x=>x.User).FirstOrDefaultAsync(x=>x.UserId==entity.UserId);
            if (isFlatInUser!=null)
            {
                return false;
            }
            var flat = await _context.Set<Flat>().Include(x=>x.User).FirstOrDefaultAsync(x=>x.Id == entity.Id);
            if (flat != null)
            {
                flat.UserId = entity.UserId;
                flat.Status = true;
                return true;
            }
            return false;
        }

        public async Task DeleteAsync(int id)
        {
            var result = await _context.Set<Flat>().FirstOrDefaultAsync(x => x.Id.Equals(id));
            _context.Remove(result!);
        }

        public List<FlatGetAllWithUsers> GetAllWithUsers()
        {
            var flatsWithUsers = _context.Flats.Include(x => x.User).Where(x=>x.User!=null).Select(x => new FlatGetAllWithUsers
            {
                Id = x.Id,
                FlatNumber = x.FlatNumber,
                Block = x.Block,
                Floor = x.Floor,
                Type = x.Type,
                Status = x.Status,
                IdentificationNumber = x.User.IdentificationNumber,
                PhoneNumber = x.User.PhoneNumber,
                Name = x.User.Name,
                Surname = x.User.Surname,

                
            }).ToList();

            return flatsWithUsers;
        }

        public async Task<Flat> GetById(int id)
        {
            var result = await _context.Set<Flat>().AsNoTracking().FirstOrDefaultAsync(x => x.Id.Equals(id));
            return result;
        }

        public async Task<bool> FlatPaymentAdd(FlatPaymentAddDto entity)
        {
            var flat = await _context.Flats.FirstOrDefaultAsync(f => f.Id == entity.Id);
            if(flat != null)
            {
                var payment = new PaymentInformation
                {
                    FlatId = flat.Id,
                    Price = entity.Price,
                    IsPayed = entity.IsPayed,
                    Year = entity.Year,
                    Month = entity.Month,
                    InvoiceTypeId = entity.InvoiceTypeId
                };
                _context.Add(payment);
                return true;
            }
            return false;
            
        }
    }
}
