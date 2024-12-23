using EstudoAulaC_163.Entities;

namespace EstudoAulaC_163
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> List = new List<Product>();

            List.Add(new Product("TV", 900.00));
            List.Add(new Product("Notebook", 1200.00));
            List.Add(new Product("Tablet", 450.00));

            //List.Sort(CompareProducts);


            Comparison<Product> comp = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()); //comp recebe os produtos p1 e p2 e retorna o resultado do que está após o => nesse caso compara se os dois são

            List.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper())); //cria o método lambda diretamente no list.sort

            foreach (Product p in List)
            {
                Console.WriteLine(p);
            }
        }
        //static int CompareProducts(Product p1, Product p2)//método estático para comparar o nome dos dois argumentos e colocar em ordem alfabética
        //{
        //    return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
        //}
    }
}
