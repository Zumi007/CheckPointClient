using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace CheckPointAdmin.Models
{
    [Table("Valaszok")]
    public class Valasz : BaseModel
    {
        [PrimaryKey("Valasz_id", false)]
        public long ValaszId { get; set; }

        [Column("Kerdes_id")]
        public long? KerdesId { get; set; }

        [Column("Valasz")]
        public string? ValaszSzoveg { get; set; }

        [Column("Helyes")]
        public bool Helyes { get; set; } = false;
    }
}