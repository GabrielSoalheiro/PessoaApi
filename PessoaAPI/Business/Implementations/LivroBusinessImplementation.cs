using PessoaAPI.Model;
using PessoaAPI.Repository;
using System.Collections.Generic;

namespace PessoaAPI.Business.Implementations
{
    public class LivroBusinessImplementation : ILivroBusiness
    {

        private readonly IRepository<Livro> _repository;

        public LivroBusinessImplementation(IRepository<Livro> repository)
        {
            _repository = repository;
        }


        public List<Livro> FindAll()
        {
            return _repository.FindAll();
        }


        public Livro FindByID(long id)
        {
            return _repository.FindByID(id);
        }


        public Livro Create(Livro livro)
        {
            return _repository.Create(livro);
        }


        public Livro Update(Livro livro)
        {
            return _repository.Update(livro);
        }


        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}
