using Microsoft.EntityFrameworkCore;

namespace VeiculosVenda.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }

        public DbSet<Veiculo> Veiculos { get; set; }

    }
}
