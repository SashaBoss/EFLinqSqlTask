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
                var res14 = db.Products.Where(product => db.Products.GroupBy(p => new
                {
                    p.maker,
                    p.type
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
                }).Contains(new { product.maker })).GroupBy(products => new
                {
                    products.maker,
                    products.type
                }).Where(g => g.Count() > 1).Select(g => new
                {
                    g.Key.maker,
                    g.Key.type
                });

                var res17 = db.Laptops.Where(l => l.speed < db.PCs.Select(pc => new { pc.speed })
                                      .Min(p => p.speed))
                                      .Select(l => new
                                      {
                                          l.Product.type,
                                          l.model,
                                          l.speed
                                      }).Distinct();

                var res23 = db.PCs.Where(pc => pc.speed >= 750 && db.Laptops.Where(laptop => laptop.speed >= 750)
                                  .Select(laptop => new
                                  {
                                      laptop.Product.maker
                                  })
                                  .Contains(new { pc.Product.maker }))
                                  .Select(pc => new
                                  {
                                      pc.Product.maker
                                  }).Distinct();

                var res24 = db.PCs.Select(pc => new
                {
                    pc.model,
                    pc.price
                })
                .Union(db.Laptops.Select(laptop => new
                {
                    laptop.model,
                    laptop.price
                }))
                .Union(db.Printers.Select(printer => new
                {
                    printer.model,
                    printer.price
                }))
                    .Where(product => product.price == db.PCs.Select(pc => new
                    {
                        pc.price
                    })
                    .Union(db.Laptops.Select(laptop => new
                    {
                        laptop.price
                    }))
                    .Union(db.Printers.Select(printer => new
                    {
                        printer.price
                    }))
                    .Select(p => new
                    {
                        p.price
                    }).Max(p => p.price)).Select(p => new
                    {
                        p.model
                    });

                Console.WriteLine();

                Console.ReadLine();
            }
        }
    }
}
