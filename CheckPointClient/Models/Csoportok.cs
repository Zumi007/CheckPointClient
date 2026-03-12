using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace CheckPointClient.Models
{
    [Table("Csoportok")]
    public class Csoport : BaseModel
    {
        [PrimaryKey("CsoportId", false)]
        public long CsoportId { get; set; }

        [Column("CsoportNev")]
        public string? CsoportNev { get; set; }

        [Column("Aktiv")]
        public bool Aktiv { get; set; } = true;
    }
}
