using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common
{
    /// <summary>
    /// Ofrece operaciones básicas CRUD para una entidad
    /// </summary>
    public interface IRepository<T>
    {
        List<T> GetAll();

        T GetById(long entityId);

        void Create(T entity);

        void Update(T entity);

        void Remove(T entity);
    }
}
