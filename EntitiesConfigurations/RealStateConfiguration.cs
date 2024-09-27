using depi_real_state_management_system.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace depi_real_state_management_system.EntitiesConfigurations
{
    public class RealStateConfiguration : IEntityTypeConfiguration<RealState>
    {
        // اعدادات الداتابيز الخاصه بالعقارات
        public void Configure(EntityTypeBuilder<RealState> builder)
        {
            builder.ToTable("RealStates");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .HasColumnType("NVARCHAR")
                .HasMaxLength(256)
                .IsRequired();

            builder.Property(x => x.Description)
                .HasColumnType("NVARCHAR")
                .HasMaxLength(256)
                .IsRequired();

            builder.Property(x => x.CreatedAt)
                .HasColumnType("DATETIME2")
                .HasMaxLength(256)
                .IsRequired();

            builder.Property(x => x.Price)
                .HasColumnType("DECIMAL(10, 2)")
                .HasMaxLength(256)
                .IsRequired();

            // Relations
            builder.HasOne(x => x.User)
                .WithMany(x => x.RealStates)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
