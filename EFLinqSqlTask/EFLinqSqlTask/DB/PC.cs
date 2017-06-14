namespace EFLinqSqlTask
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PC")]
    public partial class PC
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int code { get; set; }

        [Required]
        [StringLength(50)]
        public string model { get; set; }

        public short speed { get; set; }

        public short ram { get; set; }

        public float hd { get; set; }

        [Required]
        [StringLength(10)]
        public string cd { get; set; }

        [Column(TypeName = "money")]
        public decimal? price { get; set; }

        public virtual Product Product { get; set; }
    }
}
