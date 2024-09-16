using Microsoft.EntityFrameworkCore;

namespace FociWeb0916.Models
{
    public class FociDBContext : DbContext
    {
        public FociDBContext(DbContextOptions<FociDBContext> options) : base(options)
        {



        }

        public DbSet<Meccs> Meccs { get; set; }

    }
}
