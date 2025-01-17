using FunRunRegistration.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace FunRunRegistration.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            
        }

        // DbSet is a table in SQL
        public DbSet<Registrant> Registrants { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}
