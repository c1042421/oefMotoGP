using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace oefMotoGP.Models
{
    public class GPContext: DbContext
    {
        public GPContext(DbContextOptions<GPContext> options) :base(options) { }

        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Race> Races { get; set; }
        public virtual DbSet<Rider> Riders { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<Ticket> Tickets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().ToTable("Country");
            modelBuilder.Entity<Race>().ToTable("Race");
            modelBuilder.Entity<Rider>().ToTable("Rider");
            modelBuilder.Entity<Team>().ToTable("Team");
            modelBuilder.Entity<Ticket>().ToTable("Ticket");
        }
    }
}
