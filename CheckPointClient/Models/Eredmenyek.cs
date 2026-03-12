using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;


namespace CheckPointClient.Models
{
    [Table("Eredmenyek")]
    public class Eredmeny : BaseModel
    {
        [PrimaryKey("Eredmeny_id", false)]
        public long EredmenyId { get; set; }

        [Column("Tanulo_id")]
        public long TanuloId { get; set; }

        [Column("Teszt_id")]
        public long TesztId { get; set; }

        [Column("Pontszam")]
        public int Pontszam { get; set; }

        [Column("Ossz_Kerdes")]
        public int OsszKerdes { get; set; }

        [Column("Szazalek")]
        public decimal Szazalek { get; set; }

        [Column("Kitoltve")]
        public DateTime Kitoltve { get; set; } = DateTime.Now;
    }
}