using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Vica.Models;

namespace Vica.Services
{
    public class ServiceBase<T> : IServiceBase<T> where T: VicaModelBase
    {
        protected VicaContext NewContext()
        {
            return new VicaContext();
        }

        public T Get(Guid id)
        {
            using (var context = NewContext())
            {
                return context.Set<T>().FirstOrDefault(e => e.Id == id);
            }
        }

        public IEnumerable<T> GetAll()
        {
            using (var context = NewContext())
            {
                return context.Set<T>();
            }
        }

        public void Add(T entity)
        {
            using (var context = NewContext())
            {
                context.Set<T>().Add(entity);
                context.SaveChanges();
            }
        }

        public void AddRange(IEnumerable<T> entities)
        {
            using (var context = NewContext())
            {
                foreach (var entity in entities)
                {
                    context.Set<T>().Add(entity);
                }
                context.SaveChanges();
            }
        }
    }
}
