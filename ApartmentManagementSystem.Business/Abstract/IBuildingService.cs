using ApartmentManagementSystem.Core.Utilities;
using ApartmentManagementSystem.Entities.DTOs.BuildingDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.Business.Abstract
{
    public interface IBuildingService
    {
        IDataResult<List<BuildingGetAllDto>> GetAll();
        Task<IResult> Add(BuildingAddDto entity);
        Task<IResult> AddRangeAsync(List<BuildingAddDto> datas);

    }
}
