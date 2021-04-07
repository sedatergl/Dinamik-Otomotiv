using Microsoft.EntityFrameworkCore;
using SanalSatis.Entities.Concrete;

namespace SanalSatis.DAL.Concrete.EntityFramework
{
    public class SanalSatisContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=SEDAT-ERGUL\SEDATERGUL;Database=SanalSatisDb; Trusted_Connection=true");
        }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Brand> Brands { get; set; }
    }
}
