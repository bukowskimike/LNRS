using Microsoft.EntityFrameworkCore;

namespace ConnectionAPI.Models
{
    public class ConnectionContext : DbContext
    {
        public ConnectionContext(DbContextOptions<ConnectionContext> options) : base(options)
        {

        }

        public DbSet<Connection> Connections { get; set; }
    }
}
