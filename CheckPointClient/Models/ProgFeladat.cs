using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using System;

namespace CheckPointClient.Models
{
    [Table("Prog_Feladatok")]
    public class ProgFeladat : BaseModel
    {
        [PrimaryKey("Feladat_id", false)]
        public long FeladatId { get; set; }

        [Column("Cim")]
        public string? Cim { get; set; }

        [Column("Leiras")]
        public string? Leiras { get; set; }

        [Column("KodSablon")]
        public string? KodSablon { get; set; }

        [Column("Aktiv")]
        public bool Aktiv { get; set; } = true;
    }
}