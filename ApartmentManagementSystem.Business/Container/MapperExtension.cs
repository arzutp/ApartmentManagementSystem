using ApartmentManagementSystem.Business.Mapping;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.Business.Container;

public static class MapperExtension
{
    public static void MapperExt(this IServiceCollection services)
    {
        services.AddAutoMapper(typeof(UserMapper));
    }
}
