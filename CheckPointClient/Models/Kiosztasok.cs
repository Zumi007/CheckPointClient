using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace CheckPointClient.Models
{
    [Table("Kiosztasok")]
    public class Kiosztas : BaseModel
    {
        [PrimaryKey("Kiosztas_id", false)]
        public long KiosztasId { get; set; }

        [Column("Teszt_id")]
        public long TesztId { get; set; }

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