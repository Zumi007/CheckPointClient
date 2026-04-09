using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using System;

namespace CheckPointClient.Models
{
    [Table("Prog_Kiosztasok")]
    public class ProgKiosztas : BaseModel
    {
        [PrimaryKey("Kiosztas_id", false)]
        public long KiosztasId { get; set; }

        [Column("Feladat_id")]
        public long FeladatId { get; set; }

        [Column("Csoport_id")]
        public long CsoportId { get; set; }

        [Column("Letrehozva")]
        public DateTime Letrehozva { get; set; } = DateTime.Now;

        [Column("Hatarido")]
        public DateTime? Hatarido { get; set; }

        [Column("Aktiv")]
        public bool Aktiv { get; set; } = true;
    }
}