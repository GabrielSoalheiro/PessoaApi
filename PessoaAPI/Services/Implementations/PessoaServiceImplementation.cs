using PessoaAPI.Model;
using System.Collections.Generic;

namespace PessoaAPI.Services;

public class PessoaServiceImplementation : IPessoaService
{
    private MySQLContext _context;

    public PessoaServiceImplementation(MySQLContext context)
    {
        _context = context;
    }

    // Método responsável por devolver todas as pessoas.
    public List<Pessoa> FindAll()
    {
        return _context.Pessoas.ToList();
    }

    // Método responsável pela devolução de um Pessoa por Id
    public Pessoa FindByID(long id)
    {
        return _context.Pessoas.SingleOrDefault(p => p.Id.Equals(id));
    }

    // Método responsável pela criação de um novo Pessoa
    public Pessoa Create(Pessoa pessoa)
    {
        try
        {
            _context.Add(pessoa);
            _context.SaveChanges();
        }
        catch (Exception)
        {
            throw;
        }
        return pessoa;
    }

    // Método responsável pela atualização de uma Pessoa
    public Pessoa Update(Pessoa pessoa)
    {
        // Verificamos se a pessoa existe no banco de dados
        // Se não existir, retornamos uma instância de pessoa vazia
        if (!Exists(pessoa.Id)) return new Pessoa();

        // Obter o status atual do registro no banco de dados
        var result = _context.Pessoas.SingleOrDefault(p => p.Id.Equals(pessoa.Id));
        if (result != null)
        {
            try
            {
                // defina as alterações e salve
                _context.Entry(result).CurrentValues.SetValues(pessoa);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
        return pessoa;
    }

    // Método responsável por excluir uma pessoa de um ID
    public void Delete(long id)
    {
        var result = _context.Pessoas.SingleOrDefault(p => p.Id.Equals(id));
        if (result != null)
        {
            try
            {
                _context.Pessoas.Remove(result);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
    private bool Exists(long id)
    {
        return _context.Pessoas.Any(p => p.Id.Equals(id));
    }
}