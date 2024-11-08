using System;
using System.Globalization;
namespace EstudoAula18C_ {
    internal class Program {
        static void Main(string[] args) {
            int idade = 30;
            double saldo = 10.56743;
            string nome = "Maria";
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais",nome, idade, saldo);

            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");

            Console.WriteLine(nome+ " tem " + idade + "anos  e tem saldo igual a "+ saldo.ToString("F2",CultureInfo.InvariantCulture) + " reais ");

        }
    }
}
