using Core_Proje_API.API.Entity;
using Microsoft.EntityFrameworkCore;

namespace Core_Proje_API.API.ApiContext
{
    public class Context:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) // Veri tabanı bağlantısı
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;database=CoreProjectDB2; integrated security=true");
        }

        public DbSet<Category> Categories { get; set; }
    }
}
