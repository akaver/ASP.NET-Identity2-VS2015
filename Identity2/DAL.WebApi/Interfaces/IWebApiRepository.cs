using System.Collections.Generic;

namespace DAL.WebApi.Interfaces
{
    public interface IWebApiRepository<T> where T:class
    {
        List<T> All { get; }
    
        T GetById(object id);
        void Add(T entity);
        void Update(object id, T entity);
        void Delete(object id);
    }
}
