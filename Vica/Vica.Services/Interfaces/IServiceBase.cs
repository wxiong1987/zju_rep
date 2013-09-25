using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vica.Services
{
    public interface IServiceBase<T>
    {
        T Get(Guid id);
        IEnumerable<T> GetAll();
        void Add(T entity);
        void AddRange(IEnumerable<T> entities);
    }
}
