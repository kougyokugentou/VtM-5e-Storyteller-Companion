using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VtM_5e_Storyteller_Companion.Models.Data;

namespace VtM_5e_Storyteller_Companion.Models
{
    public class CharacterDiscipline
    {
        public int id { get; set; }
        int CharacterID { get; set; }
        int DisciplinePowerId { get; set; }
        int ? SpecialtyId { get; set; }
        int Value { get; set; }
    }
}
