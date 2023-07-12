﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VtM_5e_Storyteller_Companion.Models
{
    public class Attribute
    {
        public int Id { get; set; }
        public int CharacterID { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
    }
}
