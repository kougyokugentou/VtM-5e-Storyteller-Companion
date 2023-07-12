using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VtM_5e_Storyteller_Companion.Models.Data;

namespace VtM_5e_Storyteller_Companion.Models
{
    public class CharacterSkill
    {
        public int Id { get; set; }
        public int CharacterId { get; set; }
        public int SkillId { get; set; }
        public int ? SpecialtyId { get; set; }
        public int Value { get; set; }
    }
}
