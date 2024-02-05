using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.Core.UnitOfWorks;

public class UnitOfWork<T> : IUnitOfWork<T> where T : DbContext
{
    private readonly T _context;

    public UnitOfWork(T context)
    {
        _context = context;
    }

    public IDbContextTransaction BeginTransaction()
    {
        return _context.Database.BeginTransaction();
    }

    public int Commit()
    {
        return _context.SaveChanges();
    }

    public Task<int> CommitAsync()
    {
        return _context.SaveChangesAsync();
    }
}
