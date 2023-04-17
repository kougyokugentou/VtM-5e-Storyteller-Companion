using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VtM_5e_Storyteller_Companion.Models
{
    public class Character
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int CharacterId { get; set; }
        public string Name { get; set; }
        public string Concept { get; set; }
        public string Chronicle { get; set; }
        public string Sire { get; set; }
        public string Player { get; set; }
        public Clan Clan { get; set; }
        public string Ambition { get; set; }
        public string Desire { get; set; }
        public int Generation { get; set; }
        public int BloodPotency { get; set; }

        public int Humanity { get; set; }


    }
}
