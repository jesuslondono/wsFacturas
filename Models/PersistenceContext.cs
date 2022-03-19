using Microsoft.EntityFrameworkCore;
using wsFacturas.Models.Entities;

namespace wsFacturas.Models
{
    public class PersistenceContext : DbContext
    {
        public PersistenceContext(DbContextOptions<PersistenceContext> options) :
            base(options)
        {
        }

        public DbSet<Factura> facturas { get; set; }

    }
}
