using Pharma.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharma.Application.Common.Interfaces.Repositories
{
    public interface IRepository<TEntity> where TEntity : EntityBase
    {
        IQueryable<TEntity> GetAll();

        TEntity FindById(ulong id);
        Task<TEntity> FindByIdAsync(ulong id);

        void Add(TEntity entity);
        Task AddAsync(TEntity entity);

        void Delete(TEntity entity);

        void Update(TEntity entity);

        int SaveChanges();
        Task<int> SaveChangesAsync();
    }
}
