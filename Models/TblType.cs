using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechPackManager.Models
{
    [Table("tbl_type")]
    public class TblType
    {
        [Key]
        public int TypeId { get; set; }

        [Column("TypeName")]
        public string TypeName { get; set; } = string.Empty;
    }
}
