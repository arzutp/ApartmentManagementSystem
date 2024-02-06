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

    public async Task<T> AddAsync(T entity)
    {
        await _context.AddAsync(entity);
        return entity;
    }

    public async Task<bool> AddRangeAsync(List<T> datas)
    {
        await _context.Set<T>().AddRangeAsync(datas);
        return true;
    }

    //public async Task DeleteAsync(int id)
    //{
    //    var result = await _context.Set<T>().FirstOrDefaultAsync(x => x.Equals(id)); 
    //    _context.Remove(result!);
    //}

    public List<T> GetAll()
    {
        return _context.Set<T>().AsNoTracking().ToList();
    }

    //public async Task<T> GetById(int id)
    //{
    //    var result = await _context.Set<T>().AsNoTracking().FirstOrDefaultAsync(x=>x.Equals(id));
    //    return result;
    //}



    public async Task Update(T entity)
    {
        _context.Update(entity);    
    }
}
