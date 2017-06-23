namespace EFLinqSqlTask
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Printer")]
    public partial class Printer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int code { get; set; }

        [Required]
        [StringLength(50)]
        public string model { get; set; }

        [Required]
        [StringLength(1)]
        public string color { get; set; }

        [Required]
        [StringLength(10)]
        public string type { get; set; }

        [Column(TypeName = "money")]
        public decimal? price { get; set; }

        public virtual Product Product { get; set; }
    }
}
