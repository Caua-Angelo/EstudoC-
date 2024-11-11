using System;
using System.Globalization;

namespace ExercicioEstruturaSequencial6 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite três valores:");
            double A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            double triangulo = (A * C) / 2;//calculo da área do trapézio
            Console.WriteLine("Triangulo: " + triangulo.ToString("f3", CultureInfo.InvariantCulture));


            double PI = 3.14159;
            double circulo = PI * (Math.Pow(C, 2)); //cálculo da área de raio C do circulo
            Console.WriteLine("circulo: " + circulo.ToString("f3"));

            double trapezio = (A + B) * C / 2; //cálculo da área do trapézio
            Console.WriteLine("Trapézio: " + trapezio.ToString("f3"));

            double quadrado = Math.Pow(B, 2);//cálculo da area do quadrado
            Console.WriteLine("Quadrado: " + quadrado.ToString("f3"));

            double retangulo = A * B;
            Console.WriteLine("Retangulo: " + retangulo.ToString("f3"));

        }
    }
}
