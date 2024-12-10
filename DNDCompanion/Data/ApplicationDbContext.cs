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
    }
}
