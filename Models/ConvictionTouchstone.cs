using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VtM_5e_Storyteller_Companion.Models
{
    public class ConvictionTouchstone
    {
        public int Id { get; set; }
        int CharacterId { get; set; }
        string Conviction { get; set; }
        string Touchstone { get; set; }
    }
}
