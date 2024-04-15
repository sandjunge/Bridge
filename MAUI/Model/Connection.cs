using Microsoft.EntityFrameworkCore;

namespace MAUI.Model;

public class Connection : DbContext
{
    public DbSet<Account> Accounts { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if(!optionsBuilder.IsConfigured) optionsBuilder.UseSqlite("Data Source=Accounts.db");
    }

    public Connection()
    {
        
    }

    public Connection(DbContextOptions<Connection> options) : base(options)
    {
        
    }
}