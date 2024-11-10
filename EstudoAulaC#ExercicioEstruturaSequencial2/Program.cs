using System;
using System.Globalization;
namespace EstudoAulaC_ExercicioEstruturaSequencial2 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite o valor do raio do circulo ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double pi = 3.14159;
            double areaRaio = pi * Math.Pow(raio, 2);

            Console.WriteLine("A área do círculo é: " + areaRaio.ToString("f4",CultureInfo.InvariantCulture));
        }
    }
}
