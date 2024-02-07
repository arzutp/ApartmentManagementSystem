using ApartmentManagementSystem.Core.DataAccess;
using ApartmentManagementSystem.Entities.DTOs.FlatDtos;
using ApartmentManagementSystem.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.DataAccess.Abstract
{
    public interface IFlatRepository : IRepository<Flat>
    {
        List<FlatGetAllWithUsers> GetAllWithUsers();
        List<FlatPaymentGetAllDto> PayedGetAllDto();
        Task<bool> AddFlatOwner(Flat entity);
        Task DeleteAsync(int id);
        Task<Flat> GetById(int id);
        Task<bool> FlatPaymentAdd(FlatPaymentAddDto entity);
    }
}
