using depi_real_state_management_system.Entities;
using depi_real_state_management_system.EntitiesConfigurations;
using Microsoft.EntityFrameworkCore;

namespace depi_real_state_management_system.Data
{
    public class ApplicationDbContext : DbContext
    {
        // التابلز الخاصه بكل انتيتي
        public DbSet<ApplicationUser> Users { get; set; }
        public DbSet<RealState> RealStates { get; set; }
        // add more table if needed

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // بضيف اعدادات الداتابيز الخاصه بكل انتيتي
            modelBuilder.ApplyConfiguration(new ApplicationUserConfiguration());
            modelBuilder.ApplyConfiguration(new RealStateConfiguration());
            // add more configuration if needed

            base.OnModelCreating(modelBuilder);
        }
    }
}
