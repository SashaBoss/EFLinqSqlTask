namespace EFLinqSqlTask
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new Computer())
            {
                foreach (var product in ctx.Products)
                {
                    Console.WriteLine(product.maker);
                }
            }

            Console.ReadLine();
        }
    }
}
