using ApartmentManagementSystem.Core.Utilities;
using ApartmentManagementSystem.Entities.DTOs.RegularlyPayUserDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.Business.Abstract
{
    public interface IRegularlyPayUserService
    {
        IDataResult<List<RegularlyPayUserIndexDto>> RegularlyPayUserWithIndex(int index);
    }
}
