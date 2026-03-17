using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace CheckPointClient.Models
{
    [Table("Tanulok")]
    public class Tanulo : BaseModel
    {
        [PrimaryKey("Tanulo_id", false)]
        [Column("Tanulo_id")]
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

        [Column("auth_id")]
        public string? AuthId { get; set; }

        [Column("is_admin")]
        public bool IsAdmin { get; set; } = false;
    }
}