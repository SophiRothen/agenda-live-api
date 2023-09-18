using agenda_live_api.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace agenda_live_api.infraestrutura
{
    public class ConnectionContext : DbContext
    {
        public DbSet<Live> Lives { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         => optionsBuilder.UseSqlServer("Server=DESKTOP-L184CU4;Database=LiveList;Integrated Security=True;Trusted_Connection=True;TrustServerCertificate=True;");

    }
}
