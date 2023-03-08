using Microsoft.EntityFrameworkCore;
using Pharma.Application.Common.Interfaces.Repositories;
using Pharma.Domain.Models;
using Pharma.Infrastructure.Persistence.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharma.Infrastructure.Persistence.Repositories
{
    public class Repository<T> : IRepository<T> where T : EntityBase
    {
        private readonly DbSet<T> _dbSet;
        private readonly EFContext _context;

        public Repository(EFContext context)
        {
            _dbSet = context.Set<T>();
            _context = context;
        }

        public void Add(T entity)
        {
            _dbSet.Add(entity);
        }
        public async Task AddAsync(T entity) => await _dbSet.AddAsync(entity);

        public void Delete(T entity) => _dbSet.Remove(entity);

        public T FindById(ulong id) => _dbSet.Find(id);
        public async Task<T> FindByIdAsync(ulong id) => await _dbSet.FindAsync(id);  

        public IQueryable<T> GetAll() => _dbSet;
        public void Update(T entity) => _dbSet.Update(entity);
        

        public int SaveChanges() => _context.SaveChanges();
        public Task<int> SaveChangesAsync() => _context.SaveChangesAsync();


    }
}
