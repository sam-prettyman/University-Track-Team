using Microsoft.EntityFrameworkCore;
using UniversityRunningTeam.Models;

namespace UniversityRunningTeam.Data
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
        }

        public DbSet<Event> Events { get; set; }
        public DbSet<Trial> Trials { get; set; }
        public DbSet<Athlete> Athletes { get; set; }
        public DbSet<Field> Fields { get; set; }
        public DbSet<Coach> Coaches { get; set; }
        public DbSet<EventAssignment> EventAssignments { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Event>().ToTable("Event");
            modelBuilder.Entity<Trial>().ToTable("Trial");
            modelBuilder.Entity<Athlete>().ToTable("Athlete");
            modelBuilder.Entity<Field>().ToTable("Field");
            modelBuilder.Entity<Coach>().ToTable("Coach");
            modelBuilder.Entity<EventAssignment>().ToTable("EventAssignment");

            modelBuilder.Entity<EventAssignment>()
                .HasKey(c => new { c.EventID, c.CoachID });
        }
    }
}