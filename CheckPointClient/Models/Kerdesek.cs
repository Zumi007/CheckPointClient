using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace CheckPointAdmin.Models
{
    [Table("Kerdesek")]
    public class Kerdes : BaseModel
    {
        [PrimaryKey("Kerdes_id", false)]
        public long KerdesId { get; set; }

        [Column("Teszt_id")]
        public long? TesztId { get; set; }

        [Column("Kerdes")]
        public string? KerdesSzoveg { get; set; }
    }
}