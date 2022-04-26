using System.Globalization;
using Vetores.Exercice.entity;

namespace Vetores
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Product[] product = new Product[n];

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());

                product[i] = new Product { Name = name, Price = price };
            }

            double sum = 0.0;
            foreach (var i in product)
            {
                sum += i.Price;
            }

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Average: {(sum / n).ToString("F2", CultureInfo.CurrentCulture)}");
        }
    }
}