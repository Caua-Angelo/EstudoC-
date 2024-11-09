using System;
using System.Globalization;
namespace EstudoAulaC_23 {
    internal class Program {
        static void Main(string[] args) {
            int n1 = int.Parse(Console.ReadLine());//converte um numero de string em um número inteiro
            char ch = char.Parse(Console.ReadLine());//converte um char para string
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);//parse transforma o tipo,console.readline
                                                                                       //entra algum dado e cultureinfo transforma o , em .
            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

            Console.WriteLine("Você digitou");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString(CultureInfo.InvariantCulture));//converte para o número sair com o .
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
