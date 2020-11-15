using System;
using System.Linq;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ModelCatalogCore.Models;

#nullable disable


namespace ModelCatalogCore
{
    public class MovieCatalogContext : IdentityDbContext<AppUser>
    {
        public MovieCatalogContext()
        {
        }

        public MovieCatalogContext(DbContextOptions<MovieCatalogContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https: //go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql(
                    connectionString: "server=localhost;database=MovieCatalogCodeFirst;uid=root;pwd=password",
                    serverVersion: ServerVersion.FromString("10.4.13-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Genre> Genres { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Movie> Movies { get; set; }
    }
}