using Microsoft.EntityFrameworkCore;

using TwitterApi.Models;

namespace TwitterApi.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
    {
        
    }
    
    public  DbSet<Tweet> Tweets { get; set; }
    
    public DbSet<User> Users { get; set; }
    
    
}