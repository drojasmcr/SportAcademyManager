using Microsoft.EntityFrameworkCore;
using SportAcademyManager.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportAcademyManager.Data
{
    public class SportAcademyManagerContext : DbContext
    {
        public DbSet<Player> Players { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Persona>()
                .ToTable("Personas")
                .HasDiscriminator<int>("PersonType")
                .HasValue<Player>(0)
                .HasValue<Trainer>(1)
                .HasValue<Parent>(2);
        }
    }
}
