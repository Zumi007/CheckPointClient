using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace CheckPointAdmin.Models
{
    [Table("Tanulok")]
    public class Tanulo : BaseModel
    {
        [PrimaryKey("Tanulo_id", false)]
        public long TanuloId { get; set; }

        [Column("Csoport_id")]
        public long? CsoportId { get; set; }

        [Column("Nev")]
        public string? Nev { get; set; }

        [Column("Email")]
        public string? Email { get; set; }

        [Column("Login")]
        public string? Login { get; set; }

        [Column("Jelszo")]
        public string? Jelszo { get; set; }

        [Column("Aktiv")]
        public bool Aktiv { get; set; } = true;
    }
}
