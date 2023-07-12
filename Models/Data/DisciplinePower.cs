using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VtM_5e_Storyteller_Companion.Models.Data
{
    public class DisciplinePower
    {
        public int Id { get; set; }
        public int DisciplineId { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public int? PrereqDisciplineId { get; set; }
        public int? PrereqLevel { get; set; }
    }
}
