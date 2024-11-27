using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechPackManager.Models
{
    [Table("tbl_unit")]
    public class TblUnit
    {
        [Key]
        public int UnitId { get; set; }

        [Column("UnitName")]
        public string UnitName { get; set; } = string.Empty;
    }
}
