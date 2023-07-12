using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VtM_5e_Storyteller_Companion.Models.Data;

namespace VtM_5e_Storyteller_Companion.Models
{
    public class CharacterAdvantage
    {
        int Id { get; set; }
        int CharacterId { get; set; }
        int AdvantageId { get; set; }
    }
}
