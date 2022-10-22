using CRUDPontoTuristico.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDPontoTuristico.Context
{
    public class Conexao : DbContext
    {
        public Conexao(DbContextOptions<DbContext> options) : base(options)
        {
            
        }
        public DbSet<PontoTuristico> PontoTuristico { get; set; }
    }
}
