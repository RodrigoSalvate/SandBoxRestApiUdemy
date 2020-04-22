using SandBoxRestApiUdemy.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SandBoxRestApiUdemy.Repository.Generic
{
    public interface IRepository<T> where T : BaseEntity
    {
        T Create(T entity);
        T FindById(int id);
        List<T> FindAll();
        List<T> FindWithPagedSearch(string query);
        int GetCount(string query);
        T Update(T entity);
        void Delete(int id);
        bool Exist(int? id);
    }
}
