using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VtM_5e_Storyteller_Companion.Models
{
    public class Advantage
    {
        public int AdvantageId { get; set; }
        public string Name { get; set; }
        public enum Type
        {
            Merit = 0,
            Flaw = 1
        }
        public int Points { get; set; }

        public Character Character { get; set; }
    }
}
