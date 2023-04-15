﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VtM_5e_Storyteller_Companion.Models
{
    public class Clan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int ClanId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Bane { get; set; }
    }
}
