using ApartmentManagementSystem.DataAccess.Abstract;
using ApartmentManagementSystem.DataAccess.EntityFramework.Context;
using ApartmentManagementSystem.Entities.DTOs.PaymentInformationDtos;
using ApartmentManagementSystem.Entities.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ApartmentManagementSystem.DataAccess.EntityFramework.Repositories
{
    public class PaymentInformationRepository : BaseRepository<PaymentInformation>, IPaymentInformationRepository
    {
        public PaymentInformationRepository(ApartmentManagementDbContext context) : base(context)
        {
        }

        public async Task DeleteAsync(int id)
        {
            var result = await _context.Set<PaymentInformation>().FirstOrDefaultAsync(x => x.Id.Equals(id));
            _context.Remove(result!);
        }

        public async Task<PaymentInformation> GetById(int id)
        {
            var result = await _context.Set<PaymentInformation>().AsNoTracking().FirstOrDefaultAsync(x => x.Id.Equals(id));
            return result;
        }

        public async Task<List<PaymentGetByMonth>> GetByMonth(int month)
        {
            var result = await _context.Set<PaymentInformation>().AsNoTracking().Where(x=>x.Month == month).Include(p=>p.InvoiceType).Include(P=>P.Flats).ThenInclude(p=>p.User).Select(x=> new PaymentGetByMonth
            {
                IsPayed = x.IsPayed,
                Price = x.Price,
                Year = x.Year,
                Month = x.Month,
                InvoiceType = x.InvoiceType.Name,
                Block = x.Flats.Block,
                Floor = x.Flats.Floor,
                FlatNumber = x.Flats.FlatNumber,
                PhoneNumber = x.User.PhoneNumber,
                Name = x.User.Name,
                Surname = x.User.Surname

            }).ToListAsync();
            return result;
        }

        public async Task<decimal> GetByMonthTotal(int flatId,int month)
        {
            var result = await _context.Set<PaymentInformation>().Where(x=>x.FlatId == flatId && x.Month == month && x.IsPayed == false).SumAsync(x=>x.Price);
            return result;
        }

        public async Task<List<PaymentGetByYear>> GetByYear(int year)
        {

            var result = await _context.Set<PaymentInformation>().AsNoTracking().Where(x => x.Year == year).Include(p => p.InvoiceType).Include(P => P.Flats).ThenInclude(p => p.User).Select(x => new PaymentGetByYear
            {
                IsPayed = x.IsPayed,
                Price = x.Price,
                Year = x.Year,
                Month = x.Month,
                InvoiceType = x.InvoiceType.Name,
                Block = x.Flats.Block,
                Floor = x.Flats.Floor,
                FlatNumber = x.Flats.FlatNumber,
                PhoneNumber = x.User.PhoneNumber,
                Name = x.User.Name,
                Surname = x.User.Surname

            }).ToListAsync();
            return result;
        }

        public async Task<decimal> GetByYearTotal(int flatId, int year)
        {
            var result = await _context.Set<PaymentInformation>().Where(x => x.FlatId == flatId && x.Year == year && x.IsPayed == false).SumAsync(x => x.Price);
            return result;
        }
    }
}
