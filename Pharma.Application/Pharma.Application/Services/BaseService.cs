﻿using Pharma.Application.Common.Interfaces;
using Pharma.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharma.Application.Services
{
    public abstract class BaseService<TEntity> : IBaseService<TEntity> where TEntity : EntityBase
    {
        public virtual TEntity Create(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public virtual bool Delete(ulong id)
        {
            throw new NotImplementedException();
        }

        public virtual TEntity Get(ulong id)
        {
            throw new NotImplementedException();
        }

        public virtual TEntity Update(TEntity entity, ulong id)
        {
            throw new NotImplementedException();
        }
    }
}
