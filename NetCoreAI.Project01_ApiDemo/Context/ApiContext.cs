using Microsoft.EntityFrameworkCore;
using NetCoreAI.Project01_ApiDemo.Entities;

namespace NetCoreAI.Project01_ApiDemo.Context
{
    public class ApiContext:DbContext
    {
        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=LAPTOP-CRNMNEV7\SQLEXPRESS;Initial Catalog=ApiAIDb;Integrated Security=True;TrustServerCertificate=True");
        }
        public DbSet<Customer> Customers { get; set; }
    }
}
