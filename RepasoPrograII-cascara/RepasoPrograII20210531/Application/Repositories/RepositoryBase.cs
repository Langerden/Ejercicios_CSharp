
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Common;

namespace Application.Repositories
{
    public abstract class RepositoryBase<T> : IRepository<T>
    {
        public abstract List<T> GetAll();

        public abstract T GetById(long entityId);

        public abstract void Create(T entity);

        public abstract void Update(T entity);

        public abstract void Remove(T entity);
    }
}
