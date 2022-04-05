using API_Placas.Models;
using Microsoft.EntityFrameworkCore;

namespace API_Placas.Data
{
    public class PlacaContext : DbContext
    {
      public PlacaContext(DbContextOptions<PlacaContext> options)
    : base(options)
        {

        }
        public DbSet<Placa> Placas { get; set; }
    }
}
