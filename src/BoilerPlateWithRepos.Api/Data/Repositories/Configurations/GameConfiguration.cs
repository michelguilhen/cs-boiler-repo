using BoilerPlateWithRepos.Api.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BoilerPlateWithRepos.Api.Data.Repositories.Configurations
{
    public class GameConfiguration : IEntityTypeConfiguration<Game>
    {
        public void Configure(EntityTypeBuilder<Game> builder)
        {
            builder.ToTable("game");
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => x.Name);
            builder.Property(p => p.Name).HasMaxLength(100);
        }
    }
}
