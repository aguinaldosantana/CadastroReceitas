using CadastroReceitas.Models;
using Microsoft.EntityFrameworkCore;

namespace CadastroReceitas.Data
{
    public class ReceitaContext : DbContext
    {
        public ReceitaContext(DbContextOptions<ReceitaContext> opt) : base(opt)
        {

        }

        public DbSet<ReceitaModel> Receitas { get; set; }
    }
}
