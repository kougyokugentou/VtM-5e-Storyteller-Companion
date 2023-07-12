using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VtM_5e_Storyteller_Companion.Models.Data;

namespace VtM_5e_Storyteller_Companion.Models
{
    public class Specialty
    {
        public int Id { get; set; }
        public string SpecText { get; set;}
    }
}
