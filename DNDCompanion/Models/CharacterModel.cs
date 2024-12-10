using System.ComponentModel.DataAnnotations;
using DNDCompanion.Controllers;
using DNDCompanion.Data;
namespace DNDCompanion.Models
{
    public class CharacterModel
    {
       
            public int Id { get; set; }

            [Required]
            [StringLength(100)]
            public required string Name { get; set; }

            [Required]
            [Range(1, 20)]
            public int Level { get; set; }

            [Required]
            public required string Class { get; set; }

            public required string Race { get; set; }

            public required string Background { get; set; }

            public required string PlayerId { get; set; }
        

    }
}
