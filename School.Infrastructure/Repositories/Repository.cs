using School.Domain.Base;
using School.Domain.UserAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Infrastructure.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class, IEntity
    {
        public readonly List<TEntity> _db;

        public Repository(List<TEntity> db)
        {
            _db = db;
        }

        public virtual void Add(TEntity entity)
        {
            _db.Add(entity);
        }
    }
}
