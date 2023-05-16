using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UTunes.Core.Entities;

namespace UTunes.Infrastructure.Database.DatabaseConfiguration
{
    public class SongEntityConfiguration : IEntityTypeConfiguration<Song>
    {
        public void Configure(EntityTypeBuilder<Song> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Artist).IsRequired();
            builder.Property(x => x.PriceSong).IsRequired();
            builder.HasOne(x => x.Album)
                .WithMany(x => x.Songs)
                .HasForeignKey(x => x.AlbumId);

            builder.HasData(new Song
            {
                Name = "Don't go breaking my heart",
                Artist = "Backstreet boys",
                AlbumId = 1,
                Id = 1,
                PriceSong=0
            },
            new Song
            {
                Name = "Nobody else",
                Artist = "Backstreet boys",
                AlbumId = 1,
                Id = 2,
                PriceSong = 0
            },
            new Song
            {
                Name = "Breathe",
                Artist = "Backstreet boys",
                AlbumId = 1,
                Id = 3,
                PriceSong = 0,
            },
            new Song
            {
                Name = "New love",
                Artist = "Backstreet boys",
                AlbumId = 1,
                Id = 4,
                PriceSong = 0
            },
            new Song
            {
                Name = "40",
                Artist = "Anuel AA",
                AlbumId = 2,
                Id = 5,
                PriceSong = 0,
            },
            new Song
            {
                Name = "La 2blea",
                Artist = "Anuel AA",
                AlbumId = 2,
                Id = 6,
                PriceSong = 0,
            });

        }
    }
}

