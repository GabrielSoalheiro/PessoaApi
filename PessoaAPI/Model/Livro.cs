using PessoaAPI.Model.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PessoaAPI.Model
{
    [Table("Livro")]
    public class Livro : BaseEntity
    {
        [Column("titulo")]
        public string Title { get; set; }

        [Column("author")]
        public string Author { get; set; }

        [Column("price")]
        public decimal Price { get; set; }

        [Column("launch_date")]
        public DateTime LaunchDate { get; set; }
    }

}
