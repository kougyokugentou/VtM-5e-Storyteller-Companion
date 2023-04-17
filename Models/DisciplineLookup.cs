using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VtM_5e_Storyteller_Companion.Models
{
    public class DisciplineLookup
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int DLID { get; set; }
        public string Name { get; set; }
        public string Power { get; set; }
        public int Level { get; set; }
        public string? PrereqDisc { get; set; }
        public int? PrereqLevel { get; set; }
    }

    public class DisciplineLookupConfiguration : IEntityTypeConfiguration<DisciplineLookup>
    {
        /* Seed the Discipline Lookup table with the
         * Discipline/Power data out of the
         * VtM 5th Edition core rulebook.
         */
        public void Configure(EntityTypeBuilder<DisciplineLookup> builder)
        {
            builder.HasData
            (
                new DisciplineLookup
                {
                    DLID = 1,
                    Name = "Animalism",
                    Power = "Bond Famulus",
                    Level = 1
                },
                new DisciplineLookup
                {
                    DLID = 2,
                    Name = "Animalism",
                    Power = "Sense the Beast",
                    Level = 1
                },
                new DisciplineLookup
                {
                    DLID = 3,
                    Name = "Animalism",
                    Power = "Feral Whispers",
                    Level = 2
                },
                new DisciplineLookup
                {
                    DLID = 4,
                    Name = "Animalism",
                    Power = "Animal Succulence",
                    Level = 3
                },
                new DisciplineLookup
                {
                    DLID = 5,
                    Name = "Animalism",
                    Power = "Quell the Beast",
                    Level = 3
                },
                new DisciplineLookup
                {
                    DLID = 6,
                    Name = "Animalism",
                    Power = "Unliving Hive",
                    Level = 3,
                    PrereqDisc = "Obfuscate",
                    PrereqLevel = 2
                },
                new DisciplineLookup
                {
                    DLID = 7,
                    Name = "Animalism",
                    Power = "Subsume the Spirit",
                    Level = 4
                },
                new DisciplineLookup
                {
                    DLID = 8,
                    Name = "Animalism",
                    Power = "Animal Dominion",
                    Level = 5
                },
                new DisciplineLookup
                {
                    DLID = 9,
                    Name = "Animalism",
                    Power = "Drawing out the Beast",
                    Level = 5
                },
                new DisciplineLookup
                {
                    DLID = 10,
                    Name = "Auspex",
                    Power = "Heightened Senses",
                    Level = 1
                },
                new DisciplineLookup
                {
                    DLID = 11,
                    Name = "Auspex",
                    Power = "Sense the Unseen",
                    Level = 1
                },
                new DisciplineLookup
                {
                    DLID = 12,
                    Name = "Auspex",
                    Power = "Premonition",
                    Level = 2
                },
                new DisciplineLookup
                {
                    DLID = 13,
                    Name = "Auspex",
                    Power = "Scry the Soul",
                    Level = 3
                },
                new DisciplineLookup
                {
                    DLID = 14,
                    Name = "Auspex",
                    Power = "Share the Senses",
                    Level = 3
                },
                new DisciplineLookup
                {
                    DLID = 15,
                    Name = "Auspex",
                    Power = "Spirit's Touch",
                    Level = 4
                },
                new DisciplineLookup
                {
                    DLID = 16,
                    Name = "Auspex",
                    Power = "Clairvoyance",
                    Level = 5
                },
                new DisciplineLookup
                {
                    DLID = 17,
                    Name = "Auspex",
                    Power = "Posession",
                    Level = 5,
                    PrereqDisc = "Dominate",
                    PrereqLevel = 3
                },
                new DisciplineLookup
                {
                    DLID = 18,
                    Name = "Celerity",
                    Power = "Cat's Grace",
                    Level = 1
                },
                new DisciplineLookup
                {
                    DLID = 19,
                    Name = "Celerity",
                    Power = "Rapid Reflexes",
                    Level = 1
                },
                new DisciplineLookup
                {
                    DLID = 20,
                    Name = "Celerity",
                    Power = "Fleetness",
                    Level = 2
                },
                new DisciplineLookup
                {
                    DLID = 21,
                    Name = "Celerity",
                    Power = "Blink",
                    Level = 3
                },
                new DisciplineLookup
                {
                    DLID = 22,
                    Name = "Celerity",
                    Power = "Traversal",
                    Level = 3
                },
                new DisciplineLookup
                {
                    DLID = 23,
                    Name = "Celerity",
                    Power = "Draught of Elegance",
                    Level = 4
                },
                new DisciplineLookup
                {
                    DLID = 24,
                    Name = "Celerity",
                    Power = "Unerring Aim",
                    Level = 4,
                    PrereqDisc = "Auspex",
                    PrereqLevel = 2
                },
                new DisciplineLookup
                {
                    DLID = 25,
                    Name = "Celerity",
                    Power = "Lightning Strike",
                    Level = 5
                },
                new DisciplineLookup
                {
                    DLID = 26,
                    Name = "Celerity",
                    Power = "Lightning Strike",
                    Level = 5
                },
                new DisciplineLookup
                {
                    DLID = 27,
                    Name = "Dominate",
                    Power = "Cloud Memory",
                    Level = 1
                },
                new DisciplineLookup
                {
                    DLID = 28,
                    Name = "Dominate",
                    Power = "Compel",
                    Level = 1
                },
                new DisciplineLookup
                {
                    DLID = 29,
                    Name = "Dominate",
                    Power = "Mesmerize",
                    Level = 2
                },
                new DisciplineLookup
                {
                    DLID = 30,
                    Name = "Dominate",
                    Power = "Dementation",
                    Level = 2,
                    PrereqDisc = "Obfuscate",
                    PrereqLevel = 2
                },
                new DisciplineLookup
                {
                    DLID = 31,
                    Name = "Dominate",
                    Power = "The Forgetful Mind",
                    Level = 3
                },
                new DisciplineLookup
                {
                    DLID = 32,
                    Name = "Dominate",
                    Power = "Submerged Directive",
                    Level = 3
                },
                new DisciplineLookup
                {
                    DLID = 33,
                    Name = "Dominate",
                    Power = "Rationalize",
                    Level = 4
                },
                new DisciplineLookup
                {
                    DLID = 34,
                    Name = "Dominate",
                    Power = "Mass Manipulation",
                    Level = 5
                },
                new DisciplineLookup
                {
                    DLID = 35,
                    Name = "Dominate",
                    Power = "Terminal Decree",
                    Level = 5
                },
                new DisciplineLookup
                {
                    DLID = 36,
                    Name = "Fortitude",
                    Power = "Resilience",
                    Level = 1
                },
                new DisciplineLookup
                {
                    DLID = 37,
                    Name = "Fortitude",
                    Power = "Unswayable Mind",
                    Level = 1
                },
                new DisciplineLookup
                {
                    DLID = 38,
                    Name = "Fortitude",
                    Power = "Toughness",
                    Level = 2
                },
                new DisciplineLookup
                {
                    DLID = 39,
                    Name = "Fortitude",
                    Power = "Enduring Beasts",
                    Level = 2,
                    PrereqDisc = "Animalism",
                    PrereqLevel = 1
                },
                new DisciplineLookup
                {
                    DLID = 40,
                    Name = "Fortitude",
                    Power = "Defy Bane",
                    Level = 3
                },
                new DisciplineLookup
                {
                    DLID = 41,
                    Name = "Fortitude",
                    Power = "Fortify the Inner Facade",
                    Level = 3
                },
                new DisciplineLookup
                {
                    DLID = 42,
                    Name = "Fortitude",
                    Power = "Draught of Endurance",
                    Level = 4
                },
                new DisciplineLookup
                {
                    DLID = 43,
                    Name = "Fortitude",
                    Power = "Flesh of Marble",
                    Level = 5
                },
                new DisciplineLookup
                {
                    DLID = 44,
                    Name = "Fortitude",
                    Power = "Prowess from Pain",
                    Level = 5
                }

            ); // end builder
            DoPostConfigure();
        } // end configure

        //Add prereqs to disciplines
        void DoPostConfigure()
        {
            return;
        }
    }
}
