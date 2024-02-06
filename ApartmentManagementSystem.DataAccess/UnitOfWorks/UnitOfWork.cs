using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApartmentManagementSystem.DataAccess.EntityFramework.Context;

namespace ApartmentManagementSystem.Core.UnitOfWorks;

public class UnitOfWork: IUnitOfWork
{
    private readonly ApartmentManagementDbContext _context;

    public UnitOfWork(ApartmentManagementDbContext context)
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
