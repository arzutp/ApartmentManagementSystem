using ApartmentManagementSystem.Entities.DTOs.BuildingInvoiceDtos;
using ApartmentManagementSystem.Entities.Entity;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.Business.Mapping
{
    public class BuildingInvoiceMapper : Profile
    {
        public BuildingInvoiceMapper() { 
            CreateMap<BuildingInvoice, BuildingInvoiceAddDto>().ReverseMap();
            CreateMap<BuildingInvoice, BuildingInvoiceGetAllDto>();
        }
    }
}
