namespace EFLinqSqlTask
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Laptop")]
    public partial class Laptop
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

        [Column(TypeName = "money")]
        public decimal? price { get; set; }

        public byte screen { get; set; }

        public virtual Product Product { get; set; }
    }
}
