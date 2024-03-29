﻿using ApartmentManagementSystem.Core.Utilities;
using ApartmentManagementSystem.Entities.DTOs.FlatDtos;
using ApartmentManagementSystem.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.Business.Abstract
{
    public interface IFlatService
    {
        IDataResult<List<FlatGetAllDto>> GetAll();
        IDataResult<List<FlatGetAllWithUsers>> GetAllWithUsers();
        Task<IResult> Add(FlatAddDto entity);
        Task<IResult> AddRangeAsync(List<FlatAddDto> datas);
        Task<IResult> Update(FlatUpdateDto entity);
        Task<IResult> Delete(int id);
        Task<IDataResult<FlatGetByIdDto>> GetById(int id);
        Task<IResult> FlatAddUser(FlatUserAddDto flatUserAddDto);
        Task<IResult> FlatPaymentAdd(FlatPaymentAddDto entity);
        IDataResult<List<FlatPaymentGetAllDto>> PayedGetAllDto();
    }
}
