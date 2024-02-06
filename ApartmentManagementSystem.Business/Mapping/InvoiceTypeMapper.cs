using ApartmentManagementSystem.Entities.DTOs.InvoiceTypeDtos;
using ApartmentManagementSystem.Entities.Entity;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.Business.Mapping
{
    public class InvoiceTypeMapper : Profile
    {
        public InvoiceTypeMapper() { 
            CreateMap<InvoiceType, InvoiceTypeAddDto>().ReverseMap();
            CreateMap<InvoiceType, InvoiceTypeUpdateDto>().ReverseMap();
            CreateMap<InvoiceType, InvoiceTypeGetAllDto>();
            CreateMap<InvoiceType, InvoiceTypeGetByIdDto>();
        }
    }
}
