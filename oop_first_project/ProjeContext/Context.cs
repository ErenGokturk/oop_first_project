using Microsoft.EntityFrameworkCore;
using oop_first_project.Entity;

namespace oop_first_project.ProjeContext
{
    public class Context: DbContext

    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-HTUGQPV\\MSSQLSERVER01;database=DbNewOopCore;integrated security= true");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }  
        public DbSet<Category> Categories { get; set; } 

    }
}
