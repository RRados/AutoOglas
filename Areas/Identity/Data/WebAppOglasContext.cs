
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebAppOglas.Models;

namespace WebAppOglas.Data
{
    public class WebAppOglasContext : IdentityDbContext<IdentityUser>
    {
        public WebAppOglasContext()  { }

        public WebAppOglasContext(DbContextOptions<WebAppOglasContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
      
        }

        public DbSet<Automobil> Automobil { get; set; }
    }
}
