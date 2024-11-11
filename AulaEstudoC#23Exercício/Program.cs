using System;
using System.Globalization;
namespace AulaEstudoC_23Exercício {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Entre com seu nome completo");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa ?");
            int quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("entre com o preco de um produto");
            double preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Entre seu último nome,idade e altura(mesma)");
            string ultimonome_idade_altura = Console.ReadLine();

            string[] vet = ultimonome_idade_altura.Split(' ');
            string ultimonome = vet[0];
            string idade = vet[1];
            string altura = vet[2];

            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine(ultimonome);
            Console.WriteLine(idade);
            Console.WriteLine(altura);




        }
    }
}