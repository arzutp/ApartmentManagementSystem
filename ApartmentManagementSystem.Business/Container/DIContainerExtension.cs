﻿using ApartmentManagementSystem.Business.Abstract;
using ApartmentManagementSystem.Business.Concrete;
using ApartmentManagementSystem.Business.Token;
using ApartmentManagementSystem.Core.UnitOfWorks;
using ApartmentManagementSystem.DataAccess.Abstract;
using ApartmentManagementSystem.DataAccess.EntityFramework.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.Business.Container;

public static class DIContainerExtension
{
    public static void DIContainerExt(this IServiceCollection services)
    {
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IUserService, UserService>();

        services.AddScoped<IFlatService, FlatService>();
        services.AddScoped<IFlatRepository, FlatRepository>();

        services.AddScoped<IInvoiceTypeService, InvoiceTypeService>();
        services.AddScoped<IInvoiceTypeRepository, InvoiceTypeRepository>();

        services.AddScoped<IPaymentInformationService, PaymentInformationService>();
        services.AddScoped<IPaymentInformationRepository, PaymentInformationRepository>();

        services.AddScoped<IBuildingService, BuildingService>();
        services.AddScoped<IBuildingRepository, BuildingRepository>();

        services.AddScoped<IRoleRepository, RoleRepository>();
        services.AddScoped<IRoleService, RoleService>();

        services.AddScoped<IBuildingInvoiceRepository, BuildingInvoiceRepository>();
        services.AddScoped<IBuildingInvoiceService, BuildingInvoiceService>();

        services.AddScoped<IRegularlyPayUserService, RegularlyPayUserService>();
        services.AddScoped<IRegularlyPayUserRepository, RegularlyPayUserRepository>();

        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<IAuthService, AuthService>();
        services.AddScoped<IJwtTokenCreate, JwtTokenCreate>();
    }
}
