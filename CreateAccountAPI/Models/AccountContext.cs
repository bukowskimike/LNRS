using Microsoft.EntityFrameworkCore;

namespace AccountAPI.Models
{
    public class AccountContext : DbContext
    {
        public AccountContext(DbContextOptions<AccountContext> options) : base(options)
        {

        }

        public DbSet<Account> Accounts { get; set; }
    }
}
