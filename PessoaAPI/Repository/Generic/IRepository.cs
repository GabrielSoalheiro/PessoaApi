using PessoaAPI.Model;
using PessoaAPI.Model.Base;
using System.Collections.Generic;

namespace PessoaAPI.Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
        T Create(T item);
        T FindByID(long id);
        List<T> FindAll();
        T Update(T item);
        void Delete(long id);
        bool Exists(long id);
    }
}
