using ApartmentManagementSystem.Entities.DTOs.PaymentInformationDtos;
using ApartmentManagementSystem.Entities.Entity;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.Business.Mapping
{
    public class PaymentInformationMapper : Profile
    {
        public PaymentInformationMapper() { 
            CreateMap<PaymentInformation, PaymentInformationAddDto>().ReverseMap();
            CreateMap<PaymentInformation, PaymentInformationUpdateDto>().ReverseMap();
            CreateMap<PaymentInformation, PaymentInformationGetAllDto>();
            CreateMap<PaymentInformation, PaymentInformationGetByIdDto>();
        }
    }
}
