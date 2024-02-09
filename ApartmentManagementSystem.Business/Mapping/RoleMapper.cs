using ApartmentManagementSystem.Entities.DTOs.RoleDto;
using ApartmentManagementSystem.Entities.Entity;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.Business.Mapping
{
    public class RoleMapper : Profile
    {
        public RoleMapper() { 
            CreateMap<Role, RoleGetByNameDto>();
        }
    }
}
