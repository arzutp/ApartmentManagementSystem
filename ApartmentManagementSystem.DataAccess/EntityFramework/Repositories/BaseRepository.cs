using ApartmentManagementSystem.Core.BaseEntity;
using ApartmentManagementSystem.Core.DataAccess;
using ApartmentManagementSystem.DataAccess.EntityFramework.Context;
using ApartmentManagementSystem.Entities.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.DataAccess.EntityFramework.Repositories;

public class BaseRepository<T> : IRepository<T>
        where T : class, IEntity
{ 

    protected readonly ApartmentManagementDbContext _context;

    public BaseRepository(ApartmentManagementDbContext context)
    {
        _context = context;
    }

    public virtual async Task<T> AddAsync(T entity)
    {
        await _context.AddAsync(entity);
        return entity;
    }

    public virtual async Task<bool> AddRangeAsync(List<T> datas)
    {
        await _context.Set<T>().AddRangeAsync(datas);
        return true;
    }

    public List<T> GetAll()
    {
        return _context.Set<T>().AsNoTracking().ToList();
    }

    public async Task Update(T entity)
    {
        _context.Update(entity);    
    }
}
