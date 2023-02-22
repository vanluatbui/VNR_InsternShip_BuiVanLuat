using Microsoft.EntityFrameworkCore;
using VNR_InsternShip_BuiVanLuat.Entity;

namespace VNR_InsternShip_BuiVanLuat.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<KhoaHoc> KhoaHocs { get; set; }
        public DbSet<MonHoc> MonHocs { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //TABLE MonHoc :

            // ONE TO MANY (một khoá học có nhiều môn học)

            builder.Entity<KhoaHoc>()
    .HasMany<MonHoc>(p => p.MonHocs)
    .WithOne(q => q.KhoaHoc)
    .HasForeignKey(s => s.KhoaHocID);
        }
    }
}
