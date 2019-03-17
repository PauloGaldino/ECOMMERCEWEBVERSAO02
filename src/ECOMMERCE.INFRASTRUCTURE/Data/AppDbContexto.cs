using ECOMMERCE.APPLICATION.CORE.Entities.Bebida;
using Microsoft.EntityFrameworkCore;

namespace ECOMMERCE.INFRASTRUCTURE.Data
{
   public class AppDbContexto : DbContext
    {
        public AppDbContexto(DbContextOptions<AppDbContexto> options)
            :base(options)
        {

        }
        public DbSet<Bebida> Bebidas { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
    }
}
