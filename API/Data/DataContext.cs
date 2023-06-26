using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    // Class used that provides a link to database via inherited DbContext class
    public class DataContext : DbContext
    {
        // Constructer that passes connection string via dependency injection
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        // Creates Users table in database provider. Table columns defined by Appuser class members. 
        public DbSet<AppUser> Users { get; set; }
    }
}