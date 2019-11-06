using System;
using System.Collections.Generic;

namespace ItemsApi.Services
{
    public abstract class ServiceBase<T> : IServiceBase<T> 
        where T : class
    {
        public virtual T Find(object Id)
        {
            throw new NotImplementedException();
        }

        public virtual IEnumerable<T> FindAll()
        {
            throw new NotImplementedException();
        }

        public virtual T Add(T item)
        {
            throw new NotImplementedException();
        }

        public virtual T Remove(T item)
        {
            throw new NotImplementedException();
        }

        public virtual T Update(T item)
        {
            throw new NotImplementedException();
        }
    }
}