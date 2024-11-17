using System.Globalization;


namespace EstudoAulaC_38 {
    internal class Program {
        static void Main(string[] args) {
            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triangulo X!");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triangulo Y!");


            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (x.A + x.B + x.C) / 2.0;
            double AreaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            p = (y.A + y.B + y.C) / 2.0;
            double AreaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

            Console.WriteLine("area de X = " + AreaX.ToString("f4", CultureInfo.InvariantCulture));
            Console.WriteLine("area de Y = " + AreaY.ToString("f4", CultureInfo.InvariantCulture));

            if (AreaX > AreaY) {
                Console.WriteLine("O triangulo X é o maior");
            }
            else if (AreaY > AreaX) {
                Console.WriteLine("O triangulo Y é o maior");
            }
            else {
                Console.WriteLine("A area de ambos é igual");

            }
        }
    }
}
