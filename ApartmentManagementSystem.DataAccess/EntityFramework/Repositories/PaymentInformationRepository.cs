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

        public override async Task<PaymentInformation> AddAsync(PaymentInformation entity)
        {
            var flat = await _context.Set<Flat>().FindAsync(entity.FlatId);
            var userId = flat.UserId;
            entity.UserId = userId;
            return await base.AddAsync(entity);
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

        public async Task<Dictionary<int, decimal>> GetByMonthTotalWithFlat(int month)
        {
            var flatsWithTotalPrice = new Dictionary<int, decimal>();
            var payments = await _context.Set<PaymentInformation>().Where(x => x.Month == month && x.IsPayed == false).ToListAsync();
            foreach (var payment in payments)
            {
                if (!flatsWithTotalPrice.ContainsKey(payment.FlatId))
                {
                    flatsWithTotalPrice[payment.FlatId] = 0;
                }
                flatsWithTotalPrice[payment.FlatId] += payment.Price;
            }

            return flatsWithTotalPrice;
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

        public async Task<Dictionary<int,decimal>> GetByYearTotalWithFlat( int year)
        {
            var flatsWithTotalPrice = new Dictionary<int, decimal>();
            var payments = await _context.Set<PaymentInformation>().Where(x => x.Year == year && x.IsPayed == false).ToListAsync();
            foreach (var payment in payments)
            {
                if (!flatsWithTotalPrice.ContainsKey(payment.FlatId))
                {
                    flatsWithTotalPrice[payment.FlatId] = 0;
                }
                flatsWithTotalPrice[payment.FlatId] += payment.Price;
            }

            return flatsWithTotalPrice;
        }

        public async Task<List<PaymentGetByUser>> GetByUser(Guid userId)
        {
            var result = await _context.Set<PaymentInformation>().AsNoTracking().Include(p => p.InvoiceType).Include(P => P.Flats).ThenInclude(p => p.User).Where(x=>x.UserId == userId).Select(x => new PaymentGetByUser
            {
                IsPayed = x.IsPayed,
                Price = x.Price,
                Year = x.Year,
                Month = x.Month,
                InvoiceType = x.InvoiceType.Name,
                PhoneNumber = x.User.PhoneNumber,
                Name = x.User.Name,
                Surname = x.User.Surname

            }).ToListAsync();
            return result;
        }

        public async Task<List<PaymentGetByBuilding>> GetByBuildingNumber(int buildingNumber)
        {
            var buildings = await _context.Set<PaymentInformation>().Include(b=>b.Flats).ThenInclude(f=>f.Building).Include(f=>f.InvoiceType).Where(f=>f.Flats.Building.BuildingNumber == buildingNumber).Select(
                x=> new PaymentGetByBuilding { 
                    InvoiceType = x.InvoiceType.Name,
                    IsPayed =x.IsPayed,
                    Price = x.Price,
                    Year = x.Year,
                    Month = x.Month,
                    FlatNumber = x.Flats.FlatNumber,
                    BuildingName = x.Flats.Building.BuildingName,
                    BuildingNumber = x.Flats.Building.BuildingNumber,

                }).ToListAsync();

            return buildings;
        }

        public async Task<List<PaymentGetByMonth>> GetByMonthForUser(int month, Guid userId)
        {
            var result = await _context.Set<PaymentInformation>().AsNoTracking().Where(x => x.Month == month && x.UserId == userId).Include(p => p.InvoiceType).Include(P => P.Flats).ThenInclude(p => p.User).Select(x => new PaymentGetByMonth
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

        public async Task<List<PaymentGetByYear>> GetByYearForUser(int year, Guid userId)
        {
            var result = await _context.Set<PaymentInformation>().AsNoTracking().Where(x => x.Year == year && x.UserId == userId).Include(p => p.InvoiceType).Include(P => P.Flats).ThenInclude(p => p.User).Select(x => new PaymentGetByYear
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
    }
}
