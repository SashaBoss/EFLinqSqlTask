using EFLinqSqlTask.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFLinqSqlTask
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var product = new Product {
                    Maker = "A",
                    Model = "1",
                    Type = "PC"
                };

                ctx.Products.Add(product);
                ctx.SaveChanges();
            }
        }
    }
}
