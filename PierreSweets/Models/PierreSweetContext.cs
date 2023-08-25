using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace PierreSweets.Models
{
    public class PierreSweetContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Treat> Treats { get; set; }
        public DbSet<Flavor> Flavors { get; set; }
        public DbSet<TreatFlavor> TreatFlavors { get; set; }

        public DbSet<ApplicationUser> ApplicationUsers{ get; set; } 
        public PierreSweetContext(DbContextOptions options) : base(options) { }
    }
}