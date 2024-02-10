using ApartmentManagementSystem.Entities.DTOs.RegularlyPayUserDto;
using ApartmentManagementSystem.Entities.Entity;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.Business.Mapping
{
    public class RegularlyPayUserMapper : Profile
    {
        public RegularlyPayUserMapper()
        {
            CreateMap<RegularlyPayUser, RegularlyPayUserIndexDto>();
            CreateMap<RegularlyPayUser, RegularlyPayUserGetByYearDto>();
        }
    }
}
