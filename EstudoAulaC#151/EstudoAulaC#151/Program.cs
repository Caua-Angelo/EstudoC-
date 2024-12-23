using EstudoAulaC_151.Entities;

namespace EstudoAulaC_151

{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string a = "Maria";
            //string b = "Maria";

            //Console.WriteLine(a.GetHashCode());
            //Console.WriteLine(b.GetHashCode());


            Client a = new Client { Name = "maria", Email = "Maria@gmail.com" };
            Client b = new Client { Name = "juan", Email = "Maria@gmail.com" };

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a == b);
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
        }
    }
}
