using ApartmentManagementSystem.Core.Utilities;
using ApartmentManagementSystem.Entities.DTOs.UserDtos;
using ApartmentManagementSystem.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<UserGetAllDto>> GetAll();
        Task<IDataResult<List<Guid>>> Add(UserAddDto user);
        Task<IResult> AddRangeAsync(List<UserAddDto> datas);
        Task<IResult> Update(UserUpdateDto user);
        Task<IResult> Delete(Guid id);
        Task<IDataResult<UserGetByIdDto>> GetById(Guid id);
    }
}
