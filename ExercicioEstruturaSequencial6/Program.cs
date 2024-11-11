using System.Globalization;

namespace ExercicioEstruturaSequencial6 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite três valores:");
            double A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double triangulo = (A * C) / 2;
            Console.WriteLine("Triangulo: " + triangulo.ToString("f3", CultureInfo.InvariantCulture));

            double PI = 3.14159;
            double circulo = PI * (Math.Pow(C, 2));
            Console.WriteLine("circulo: " + circulo.ToString("f3"));

            Double trapezio = 
        }
    }
}
