using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechPackManager.Models
{
    public class TblMaterial
    {
        //[Key]
        //public int MaterialId { get; set; } 

        //[Column("ReferenceNo")]
        //public string ReferenceNo { get; set; } = "REF" + Math.Random;
        

        [Column("MaterialName")]
        public string MaterialName { get; set; } = string.Empty;

        [Column("Types")]
        public string Types { get; set; } = string.Empty;

        [Column("Units")]
        public string Units { get; set; } = string.Empty;

        [Column("Rate")]
        public decimal Rate { get; set; }

        [Key]
        [Column("Consumption")]
        public decimal Consumption { get; set; }

        // Navigation properties
        //public TblType? Type { get; set; }
        //public TblUnit? Unit { get; set; }
    }
}
