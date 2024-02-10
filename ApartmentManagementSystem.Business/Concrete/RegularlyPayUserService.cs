using ApartmentManagementSystem.Business.Abstract;
using ApartmentManagementSystem.Core.Utilities;
using ApartmentManagementSystem.DataAccess.Abstract;
using ApartmentManagementSystem.Entities.DTOs.RegularlyPayUserDto;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.Business.Concrete
{
    public class RegularlyPayUserService : IRegularlyPayUserService
    {
        private readonly IRegularlyPayUserRepository _repository;
        private readonly IMapper _mapper;

        public RegularlyPayUserService(IMapper mapper, IRegularlyPayUserRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public IDataResult<List<RegularlyPayUserIndexDto>> RegularlyPayUserWithIndex(int index)
        {
            var dto = _repository.GetRegularlyPayUser(index);
            var results = _mapper.Map<List<RegularlyPayUserIndexDto>>(dto);
            return new SuccessDataResult<List<RegularlyPayUserIndexDto>>(results);
        }
    }
}
