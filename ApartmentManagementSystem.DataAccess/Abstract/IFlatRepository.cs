using ApartmentManagementSystem.Core.BaseEntity;
using ApartmentManagementSystem.Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.DataAccess.Abstract
{
    public interface IFlatRepository<T> : IRepository<T> where T : class, IEntity
    {
    }
}
