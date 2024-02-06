using ApartmentManagementSystem.Entities.DTOs.FlatDtos;
using ApartmentManagementSystem.Entities.Entity;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.Business.Mapping
{
    public class FlatMapper : Profile
    {
        public FlatMapper() {
            CreateMap<Flat, FlatAddDto>().ReverseMap();
            CreateMap<Flat, FlatUpdateDto>().ReverseMap();
            CreateMap<Flat, FlatGetAllDto>();
            CreateMap<Flat, FlatGetByIdDto>();
        }
    }
}
