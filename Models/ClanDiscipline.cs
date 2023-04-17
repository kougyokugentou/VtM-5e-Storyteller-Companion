using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VtM_5e_Storyteller_Companion.Models
{
    public class ClanDiscipline
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int CdId { get; set; }
        public string Name { get; set; }
        Clan Clan { get; set; }
    }

    public class ClanDisciplineConfiguration : IEntityTypeConfiguration<ClanDiscipline>
    {
        public void Configure(EntityTypeBuilder<ClanDiscipline> builder)
        {
            builder.HasData
            (
                new ClanDiscipline
                {
                    CdId = 1,
                    Name = "Auspex",
                    Clan = GetClan("Malkavian")
                },
                new ClanDiscipline
                {
                    CdId = 1,
                    Name = "Auspex",
                    Clan = GetClan("Toreador")
                },
                new ClanDiscipline
                {
                    CdId = 1,
                    Name = "Auspex",
                    Clan = GetClan("Tremere")
                }
            )
        }
    }
}
