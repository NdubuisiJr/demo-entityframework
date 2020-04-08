using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace SQliteDemo {

    public class DatabaseContext : DbContext {
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<ArtistDetails> ArtistDetails { get; set; }
        public DbSet<Reviewer> Reviewers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<AlbumReviewer>().HasKey(ar => new { ar.AlbumID, ar.ReviewerID });
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlite(connectionString);

        }

        string connectionString = @"Data Source = SQliteEntity.db;";
    }
}
