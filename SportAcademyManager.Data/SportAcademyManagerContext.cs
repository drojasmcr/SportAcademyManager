using Microsoft.EntityFrameworkCore;
using SportAcademyManager.Domain;

namespace SportAcademyManager.Data
{
    public class SportAcademyManagerContext : DbContext
    {
        public DbSet<Player> Players { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Academy> Academies { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<PlayerSkill> PlayerSkill { get; set; }
        public DbSet<PlayerTeam> PlayerTeam { get; set; }
        public DbSet<PlayerPosition> PlayerPositions { get; set; }

        string connectionString = "Data Source=.;Initial Catalog=SportAcademyManager;Integrated Security=True";
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PlayerPosition>()
                .HasKey(pp => new { pp.PlayerId, pp.PositionId});
            modelBuilder.Entity<PlayerPosition>()
                .HasOne(pp => pp.CurrentPlayer)
                .WithMany(p => p.PlayersPositions)
                .HasForeignKey( pp => pp.PlayerId);
            modelBuilder.Entity<PlayerPosition>()
                .HasOne(pp => pp.CurrentPosition)
                .WithMany(p => p.PlayersPositions)
                .HasForeignKey(pp => pp.PositionId);

            modelBuilder.Entity<PlayerTeam>()
                .HasKey( pt => new { pt.PlayerId, pt.TeamId });
            modelBuilder.Entity<PlayerTeam>()
                .HasOne(pt => pt.CurrentPlayer)
                .WithMany(p => p.PlayerTeams)
                .HasForeignKey(pt => pt.PlayerId);
            modelBuilder.Entity<PlayerTeam>()
                .HasOne(pt => pt.CurrentTeam)
                .WithMany(t => t.PlayerTeams)
                .HasForeignKey( pt => pt.TeamId);

            modelBuilder.Entity<PlayerSkill>()
                .HasKey( ps => new { ps.PlayerId, ps.SkillId } );
            modelBuilder.Entity<PlayerSkill>()
                .HasOne(ps => ps.CurrentPlayer)
                .WithMany( p => p.PlayersSkills)
                .HasForeignKey( ps => ps.PlayerId);
            modelBuilder.Entity<PlayerSkill>()
                .HasOne(ps => ps.CurrentSkill)
                .WithMany(s => s.PlayersSkills)
                .HasForeignKey(ps => ps.SkillId);

            modelBuilder.Entity<Persona>()
                .ToTable("Personas")
                .HasDiscriminator<int>("PersonType")
                .HasValue<Player>(0)
                .HasValue<Trainer>(1)
                .HasValue<Parent>(2);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
            
        }

    }
}
