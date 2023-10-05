using BoilerPlateWithRepos.Api.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BoilerPlateWithRepos.Api.Data.Configurations
{
    public class GameConfiguration : IEntityTypeConfiguration<Game>
    {
        public void Configure(EntityTypeBuilder<Game> builder)
        {
            builder.ToTable("tb_game");

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

            builder.HasData(new Game[] {
                new() {Id = new Guid("b60f059a-2cd8-48ee-b4c0-db3e577f081f"), Name = "Elden Ring", Description = "bla bla"},
                new() {Id = new Guid("2cd305a3-55ec-484c-9df1-adc7bc7c417c"), Name = "Crash Bandicoot", Description = "ble ble"},
            });
        }
    }
}
