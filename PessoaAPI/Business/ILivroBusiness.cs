using PessoaAPI.Model;
using System.Collections.Generic;

namespace PessoaAPI.Business
{
    public interface ILivroBusiness
    {
        Livro Create(Livro livro);
        Livro FindByID(long id);
        List<Livro> FindAll();
        Livro Update(Livro livro);
        void Delete(long id);
    }
}
