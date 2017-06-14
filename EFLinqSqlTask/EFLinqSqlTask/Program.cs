namespace EFLinqSqlTask
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new Computer())
            {
                var res14 = db.Products.Where(products => db.Products.GroupBy(products0 => new
                {
                    products0.maker,
                    products0.type
                }).Select(g => new
                {
                    g.Key.maker,
                    g.Key.type
                }).GroupBy(x => new
                {
                    x.maker
                }).Where(g => g.Count() == 1).Select(g => new
                {
                    g.Key.maker
                }).Contains(new {products.maker })).GroupBy(products => new
                {
                    products.maker,
                    products.type
                }).Where(g => g.Count() > 1).Select(g => new
                {
                    g.Key.maker,
                    g.Key.type
                });

                Console.ReadLine();
            }
        }
    }
}
