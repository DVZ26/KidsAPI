using KidsAPI.Entitys.OneToMany;
using Microsoft.EntityFrameworkCore;

namespace KidsAPI.DBContext
{
    public class KidsDBContext : DbContext
    {
        public DbSet<Kid> Kids { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public KidsDBContext(DbContextOptions<KidsDBContext> options)
        : base(options)
        {
         
        }

    }
}
