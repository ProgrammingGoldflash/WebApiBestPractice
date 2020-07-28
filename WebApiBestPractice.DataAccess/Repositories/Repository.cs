using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using WebApiBestPractice.Domain.Interfaces.Repositories;

namespace WebApiBestPractice.DataAccess.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        #region Private Fields

        private readonly DbSet<T> _entities;

        #endregion Private Fields

        #region Public Constructors

        public Repository(DbContext dbContext)
        {
            _entities = dbContext.Set<T>();
        }

        #endregion Public Constructors

        #region Public Methods

        public async Task<T> AddAsync(T entity)
        {
            return (await _entities.AddAsync(entity)).Entity;
        }

        public async Task AddRangeAsync(IEnumerable<T> entities)
        {
            await _entities.AddRangeAsync(entities);
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return _entities.Where(predicate);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _entities.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _entities.FindAsync(id);
        }

        public void Remove(T entity)
        {
            _entities.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            _entities.RemoveRange(entities);
        }

        public T Update(T entity)
        {
            return _entities.Update(entity).Entity;
        }

        #endregion Public Methods
    }
}