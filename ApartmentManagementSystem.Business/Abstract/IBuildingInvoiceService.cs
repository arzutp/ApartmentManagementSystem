using ApartmentManagementSystem.Core.Utilities;
using ApartmentManagementSystem.Entities.DTOs.BuildingInvoiceDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.Business.Abstract
{
    public interface IBuildingInvoiceService
    {
        IDataResult<List<BuildingInvoiceGetAllDto>> GetAll();
        Task<IResult> Add(BuildingInvoiceAddDto entity);
        Task<IResult> AddRangeAsync(List<BuildingInvoiceAddDto> datas);
    }
}
