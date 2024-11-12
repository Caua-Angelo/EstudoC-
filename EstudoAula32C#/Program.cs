using System;
using System.Globalization;
namespace EstudoAula32C_ {

    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite um número");
            String[] vet = Console.ReadLine().Split(' ');
                double num = double.Parse(vet[0], CultureInfo.InvariantCulture);

            while (num >= 0.0) {

                double raiz = Math.Sqrt(num);
                Console.WriteLine("A raiz quadrada é :" + raiz.ToString("f3", CultureInfo.InvariantCulture));
                Console.WriteLine("Digite outro número");
                num = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Numero negativo!");
        }
    }
}