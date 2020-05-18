using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReactWebApp.Repository
{
    public interface IBaseRepository<T> where T : class
    {
        T GetById(int id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        object GetById(object id);
    }
}
