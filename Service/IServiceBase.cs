using System.Collections.Generic;

namespace ItemsApi.Services
{
    public interface IServiceBase<T>
        where T : class
    {
        T Find(object Id);
        IEnumerable<T> FindAll();
        T Remove(T item);
        T Update(T item);
    }
}
