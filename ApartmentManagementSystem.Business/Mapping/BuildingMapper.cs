using ApartmentManagementSystem.Entities.DTOs.BuildingDto;
using ApartmentManagementSystem.Entities.Entity;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.Business.Mapping
{
    public class BuildingMapper : Profile
    {
        public BuildingMapper() { 
            CreateMap<Building, BuildingAddDto>().ReverseMap();
            CreateMap<Building, BuildingGetAllDto>();
        }
    }
}
