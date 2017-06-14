using System.Collections.Generic;

namespace EFLinqSqlTask.DB
{
    public class Product
    {
        public string Maker { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }

        public virtual ICollection<PC> PCs { get; set; }
        public virtual ICollection<Laptop> Laptops { get; set; }
        public virtual ICollection<Printer> Printers { get; set; }
    }
}