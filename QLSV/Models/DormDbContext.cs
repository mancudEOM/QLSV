using Microsoft.EntityFrameworkCore;


namespace QLSV.Models
{
    public class DormDbContext : DbContext
    {
        public DormDbContext(DbContextOptions<DormDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Khởi tạo quan hệ 1-n cho User và RelativeUser ( half )
            modelBuilder.Entity<User>().HasMany(x => x.RelativeUsers).WithOne().OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<User>().Navigation(x => x.RelativeUsers).UsePropertyAccessMode(PropertyAccessMode.Property);

            //Khởi tạo quan hệ 1-n cho HistoryRent và Rent ( half )
            modelBuilder.Entity<HistoryRent>().HasMany(x => x.Rents).WithOne().OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<HistoryRent>().Navigation(x => x.Rents).UsePropertyAccessMode(PropertyAccessMode.Property);
        }

        public DbSet<User>? Users { get; set; } = null!;
        public DbSet<Room>? Rooms { get; set; } = null!;
        public DbSet<RelativeUser>? RelativeUsers { get; set; } = null!;
        public DbSet<HistoryRent>? HistoryRents { get; set; } = null!;
        public DbSet<Rent>? Rents { get; set; } = null!;
    }
}
