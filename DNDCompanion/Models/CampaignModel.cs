using System.ComponentModel.DataAnnotations;
using DNDCompanion.Controllers;
using DNDCompanion.Data;

namespace DNDCompanion.Models
{
    public class CampaignModel
    {
        public int Id { get; set; }

        [Required]
        public required string Name { get; set; }

        public required string DungeonMasterId { get; set; }
        public ICollection<CharacterModel>? Characters { get; set; }
    }
}
