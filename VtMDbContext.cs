using Microsoft.EntityFrameworkCore;
using VtM_5e_Storyteller_Companion.Models;

namespace VtM_5e_Storyteller_Companion
{
    public class VtMDbContext : DbContext
    {
        public DbSet<Advantage> Advantages { get; set; }
        public DbSet<Models.Attribute> Attributes { get; set; }
        public DbSet<Character> Characters { get; set; }
        public DbSet<Clan> Clans { get; set; }
        public DbSet<DisciplineLookup> DisciplineLookups { get; set; }
        public DbSet<Discipline> Disciplines { get; set; }
        public DbSet<Predator> Predators { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Specialty> Specialtys { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=.;Database=VtM5eStoryteller;Trusted_Connection=True;TrustServerCertificate=True;";
            if (!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.UseSqlite("Data Source=VtM.db");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClanConfiguration());
            modelBuilder.ApplyConfiguration(new DisciplineLookupConfiguration());
        }
    }
}
