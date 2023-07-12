using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VtM_5e_Storyteller_Companion.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Concept { get; set; }
        public string Chronicle { get; set; }
        public string Sire { get; set; }
        public string Player { get; set; }
        public int ClanId { get; set; }
        public string Ambition { get; set; }
        public string Desire { get; set; }
        public int Generation { get; set; }
        public int BloodPotency { get; set; }
        public int Humanity { get; set; }
    }
}
