﻿using BoilerPlateWithRepos.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BoilerPlateWithRepos.Api.Data.Configurations;
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

        builder.HasOne(p => p.Publisher)
            .WithMany(p => p.Games)
            .HasForeignKey("publisher_id");
    }
}
