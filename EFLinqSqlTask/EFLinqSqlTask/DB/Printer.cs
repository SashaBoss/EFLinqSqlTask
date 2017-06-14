using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFLinqSqlTask.DB
{
    public class Printer
    {
        public int Code { get; set; }
        public string Model { get; set; }
        public char Color { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }

        public virtual Product Product { get; set; }
    }
}
