using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using System;

namespace CheckPointClient.Models
{
    [Table("Prog_Beadasok")]
    public class ProgBeadas : BaseModel
    {
        [PrimaryKey("Beadas_id", false)]
        public long BeadasId { get; set; }

        [Column("Kiosztas_id")]
        public long KiosztasId { get; set; }

        [Column("Tanulo_id")]
        public long TanuloId { get; set; }

        [Column("BekuldottKod")]
        public string? BekuldottKod { get; set; }

        [Column("Statusz")]
        public string Statusz { get; set; } = "Bekuldve";

        [Column("Ai_Szoveg")]
        public string? AiSzoveg { get; set; }

        [Column("Ai_Szazalek")]
        public int? AiSzazalek { get; set; }

        [Column("Ai_Jegy")]
        public int? AiJegy { get; set; }

        [Column("Vegleges_Szazalek")]
        public int? VeglegesSzazalek { get; set; }

        [Column("Vegleges_Jegy")]
        public int? VeglegesJegy { get; set; }

        [Column("Tanari_Megjegyzes")]
        public string? TanariMegjegyzes { get; set; }

        [Column("Bekuldve")]
        public DateTime Bekuldve { get; set; } = DateTime.Now;
    }
}