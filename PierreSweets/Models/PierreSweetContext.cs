using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PierreSweets.Models
{
    public class PierreSweetContext : IdentityDbContext<Account>
    {
        public DbSet<Treat> Treats { get; set; }
        public DbSet<Flavor> Flavors { get; set; }
          public DbSet<TreatFlavor> TreatFlavors { get; set; }

        public PierreSweetContext(DbContextOptions options) : base(options) { }
    }
}