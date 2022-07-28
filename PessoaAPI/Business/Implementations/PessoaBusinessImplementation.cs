using PessoaAPI.Model;
using PessoaAPI.Repository;

namespace PessoaAPI.Business.Implementations
{
    public class PessoaBusinessImplementation : IPessoaBusiness
    {

        private readonly IRepository<Pessoa> _repository;

        public PessoaBusinessImplementation(IRepository<Pessoa> repository)
        {
            _repository = repository;
        }

        // Método responsável por devolver todas as pessoas
        public List<Pessoa> FindAll()
        {
            return _repository.FindAll();
        }

        // Método responsável pela devolução de um Pessoa por ID
        public Pessoa FindByID(long id)
        {
            return _repository.FindByID(id);
        }

        // Método responsável pela criação de um novo Pessoa
        public Pessoa Create(Pessoa pessoa)
        {
            return _repository.Create(pessoa);
        }

        // Método responsável por atualizar uma pessoa
        public Pessoa Update(Pessoa pessoa)
        {
            return _repository.Update(pessoa);
        }

        // Método responsável por excluir uma pessoa de um ID
        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}
