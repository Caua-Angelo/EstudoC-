using System;
using System.Globalization;
namespace EstudoAula23C_exercicioReforco {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Entre com seu nome Completo: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa?");
            int NumQuartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto: ");
            double PrecoProduto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            

            Console.WriteLine("Entre com seu último nome,idade e altura (mesma linha)");
            string[] vet = Console.ReadLine().Split();

            string ultimonome = vet[0];
            string idade = vet[1];
            string altura = vet[2];

            Console.WriteLine("Seu nome é: " + nome );
            Console.WriteLine("Sua casa tem: " + NumQuartos + " quartos");
            Console.WriteLine("O preço do produto é: " + PrecoProduto.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("Seu ultimo nome é:" + ultimonome);
            Console.WriteLine("Sua idade é: " + idade);
            Console.WriteLine("sua altura é: " + altura);
            
        }
    }
}