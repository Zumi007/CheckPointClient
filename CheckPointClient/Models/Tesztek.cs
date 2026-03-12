using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace CheckPointAdmin.Models
{
    [Table("Tesztek")]
    public class Teszt : BaseModel
    {
        [PrimaryKey("Teszt_id", false)]
        public long TesztId { get; set; }

        [Column("TesztCime")]
        public string? TesztCime { get; set; }

        [Column("Leiras")]
        public string? Leiras { get; set; }

        [Column("Aktiv")]
        public bool Aktiv { get; set; } = true;
    }
}