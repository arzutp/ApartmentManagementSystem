using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.Core.UnitOfWorks;

public interface IUnitOfWork<T> where T : DbContext
{
    int Commit();
    Task<int> CommitAsync();
    IDbContextTransaction BeginTransaction();
}
