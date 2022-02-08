using CadastroReceitas.Models;
using Microsoft.EntityFrameworkCore;

namespace CadastroReceitas.Data
{
    public class DespesaContext : DbContext
    {
        public DespesaContext(DbContextOptions<DespesaContext> opt) : base(opt)
        {

        }

        public DbSet<DespesaModel> Despesas { get; set; }
    }
}
