using System;
using System.Linq;
using System.Linq.Expressions;
using Contracts.IServices;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository.Repositoies
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T :class
    {
        private readonly Api21DbContext _context;

        public RepositoryBase(Api21DbContext context)
        {
            _context = context;
        }

        public IQueryable<T> FindAll(bool trackChange)
        {
            return !trackChange ? _context.Set<T>().AsNoTracking() : _context.Set<T>();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public void Create(T entity)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }
    }
}