using Microsoft.EntityFrameworkCore;

namespace PessoaAPI.Model
{
    public class MySQLContext : DbContext
    {
        public MySQLContext()
        {

        }
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) { }

        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Livro> Livros { get; set; }
    }
}
