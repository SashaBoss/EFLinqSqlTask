using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFLinqSqlTask.DB
{
    public class Laptop
    {
        public int Code { get; set; }
        public string Model { get; set; }
        public int Speed { get; set; }
        public int Ram { get; set; }
        public int Hd { get; set; }
        public decimal Price { get; set; }
        public int Screen { get; set; }

        public virtual Product Product { get; set; }
    }
}
