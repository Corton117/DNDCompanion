using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using DNDCompanion.Models;

namespace DNDCompanion.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<CharacterModel> Characters { get; set; }
        public DbSet<CampaignModel> Campaigns { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<CharacterModel>().HasData(
                new CharacterModel
                {
                    Id = 1,
                    Name = "Aragorn",
                    Level = 5,
                    Class = "Ranger",
                    Race = "Human",
                    Background = "Noble",
                    PlayerId = "1"
                }
            );
        }
    }
}
