using Explorer.Models;
using Microsoft.EntityFrameworkCore;

namespace Explorer.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Document> Documents { get; set; }
        public DbSet<Folder> Folders { get; set; }
        public DbSet<Extension> Extensions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Document>().ToTable("Document");
            modelBuilder.Entity<Extension>().ToTable("Extension");
            modelBuilder.Entity<Folder>().ToTable("Folder");
        }
    }
}
