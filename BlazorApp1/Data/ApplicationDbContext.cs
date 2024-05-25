
using Microsoft.EntityFrameworkCore;
using BlazorApp1.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace BlazorApp1.Data
{
    public class ApplicationDbContext : DbContext
    {
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // Add the song, playlist, and playlist item models to the database context as DB sets
        public DbSet<SongModel> Songs { get; set; }
        public DbSet<PlaylistModel> Playlists { get; set; }
        public DbSet<PlaylistItem> PlaylistItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Add the many-to-many relationship between the playlist and song models
            modelBuilder.Entity<PlaylistItem>().HasKey(pi => new { pi.PlaylistId, pi.SongId });

            modelBuilder.Entity<PlaylistItem>().HasOne(pi => pi.playlistModel).WithMany(p => p.PlaylistItems).HasForeignKey(pi => pi.PlaylistId);

            modelBuilder.Entity<PlaylistItem>().HasOne(pi => pi.SongModel).WithMany(s => s.PlaylistItems).HasForeignKey(pi => pi.SongId);

            modelBuilder.Entity<SongModel>().ToTable("Song");
            modelBuilder.Entity<PlaylistModel>().ToTable("Playlist");
            modelBuilder.Entity<PlaylistItem>().ToTable("PlaylistItem");
        }
    }
}
