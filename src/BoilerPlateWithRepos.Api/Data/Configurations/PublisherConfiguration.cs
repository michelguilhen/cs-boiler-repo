using BoilerPlateWithRepos.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BoilerPlateWithRepos.Api.Data.Configurations;
public class PublisherConfiguration : IEntityTypeConfiguration<Publisher>
{
    public void Configure(EntityTypeBuilder<Publisher> builder)
    {
        builder.ToTable("tb_publisher");

        // id
        builder.Property(p => p.Id)
            .HasColumnName("id");
        builder.HasKey(p => p.Id);

        // name
        builder.Property(p => p.Name)
            .HasColumnName("name")
            .HasMaxLength(100);
        builder.HasIndex(p => p.Name);

        // description
        builder.Property(p => p.Description)
            .HasColumnName("description")
            .HasMaxLength(500);

        builder.HasMany(p => p.Games)
            .WithOne(p => p.Publisher)
            .HasForeignKey("publisher_id");
    }
}
