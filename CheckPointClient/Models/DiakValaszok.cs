using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace CheckPointAdmin.Models
{
    [Table("Diak_Valaszok")]
    public class DiakValasz : BaseModel
    {
        [PrimaryKey("Id", false)]
        public long Id { get; set; }

        [Column("Eredmeny_id")]
        public long EredmenyId { get; set; }

        [Column("Kerdes_id")]
        public long KerdesId { get; set; }

        [Column("Valasztott_Valasz_id")]
        public long ValasztottValaszId { get; set; }
    }
}