using ApartmentManagementSystem.Core.Utilities;
using ApartmentManagementSystem.Entities.DTOs.FlatDtos;
using ApartmentManagementSystem.Entities.DTOs.InvoiceTypeDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.Business.Abstract
{
    public interface IInvoiceTypeService
    {
        IDataResult<List<InvoiceTypeGetAllDto>> GetAll();
        Task<IResult> Add(InvoiceTypeAddDto entity);
        Task<IResult> AddRangeAsync(List<InvoiceTypeAddDto> datas);
        Task<IResult> Update(InvoiceTypeUpdateDto entity);
        Task<IResult> Delete(int id);
        Task<IDataResult<InvoiceTypeGetByIdDto>> GetById(int id);
    }
}
