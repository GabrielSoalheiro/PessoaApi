using PessoaAPI.Model.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace PessoaAPI.Model;

public class Pessoa : BaseEntity
{

    [Column("nome")]
    public string Nome { get; set; }

    [Column("sobrenome")]
    public string Sobrenome { get; set; }

    [Column("endereco")]
    public string Endereco { get; set; }
    [Column("genero")]
    public string Genero { get; set; }
}