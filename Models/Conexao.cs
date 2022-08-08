using Microsoft.EntityFrameworkCore;

namespace API_CINEMA.Models
{
    public class Conexao: DbContext
    {
        public Conexao(DbContextOptions<Conexao> options): base(options) {
        

        }

        public DbSet<Filmes> Filmes { get; set; }
    }
}
