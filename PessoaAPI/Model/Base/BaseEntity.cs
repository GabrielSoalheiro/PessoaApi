using System.ComponentModel.DataAnnotations.Schema;

namespace PessoaAPI.Model.Base
{
    public class BaseEntity
    {
        [Column("id")]
        public long Id { get; set; }
    }
}
