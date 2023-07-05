using Microsoft.EntityFrameworkCore;

namespace Music.Models
{
    public class MusicDbContext: DbContext
    {
        public MusicDbContext(DbContextOptions options): base(options)
        {
            
        }

        public DbSet<ArtistDb> ArtistDbs { get; set; }
        public DbSet<AlbumDb> AlbumDbs { get; set; }
        public DbSet<Track> Tracks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Track>()
                        .HasOne(pt => pt.ArtistDb)
                        .WithMany(p => p.Tracks)
                        .HasForeignKey(pt => pt.ArtistDbId);

            modelBuilder.Entity<Track>()
                .HasOne(pt => pt.AlbumDb)
                .WithMany(p => p.Tracks)
                .HasForeignKey(pt => pt.AlbumDbId);
        }
    }
}
