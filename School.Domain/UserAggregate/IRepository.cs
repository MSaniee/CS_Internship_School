using School.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Domain.UserAggregate
{
    public interface IRepository<TEntity> where TEntity : class , IEntity
    {
        void Add(TEntity entity);
    }
}
