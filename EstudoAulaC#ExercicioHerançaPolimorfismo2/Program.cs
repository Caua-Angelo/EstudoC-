using EstudoAulaC_ExercicioHerançaPolimorfismo2.Entities;

namespace EstudoAulaC_ExercicioHerançaPolimorfismo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            Console.Write("Enter the number of products: ");
            int qtprodutos = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtprodutos; i++)
            {
                Console.WriteLine("Product#" + i + "data: ");
                Console.Write("Common,used or imported (c/u/i) ");
                string productType = Console.ReadLine();

                if (productType == "c" || productType == "C")
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine());

                    products.Add(new Product(name, price));
                }
                else if (productType == "u" || productType == "U")
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine());
                    Console.Write("Manufacture date: ");
                    DateTime data = DateTime.Parse(Console.ReadLine());
                     
                    products.Add(new UsedProduct(name, price, data));
                }
                else if (productType == "i" || productType == "I")
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine());
                    Console.Write("Customs fee: ");
                    double customsfee = double.Parse(Console.ReadLine());
                    products.Add(new ImportedProduct(name, price, customsfee));
                }
                else
                {
                    Console.WriteLine("Entrada errada,Programa encerrado");
                    Environment.Exit(0);
                }
                Console.WriteLine();
            }
                foreach (Product product in products)
                {
                    Console.WriteLine(product.priceTag());
                }
        }
    }
}