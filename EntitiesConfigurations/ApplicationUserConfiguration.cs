using depi_real_state_management_system.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace depi_real_state_management_system.EntitiesConfigurations
{
    public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        // اعدادات الداتابيز الخاصه باليوزرز
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.ToTable("Users");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .HasColumnType("VARCHAR")
                .HasMaxLength(256)
                .IsRequired();

            builder.Property(x => x.Email)
                .HasColumnType("VARCHAR")
                .HasMaxLength(256)
                .IsRequired();

            builder.Property(x => x.Password)
                .HasColumnType("VARCHAR")
                .HasMaxLength(256)
                .IsRequired();
        }
    }
}
