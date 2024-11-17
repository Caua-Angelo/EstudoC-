using System.Globalization;


namespace EstudoAulaC_38 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Entre com as medidas do triangulo X!");
            string[] trianguloX = Console.ReadLine().Split(' ');
            double xa = double.Parse(trianguloX[0], CultureInfo.InvariantCulture);
            double xb = double.Parse(trianguloX[1], CultureInfo.InvariantCulture);
            double xc = double.Parse(trianguloX[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triangulo Y!");
            string[] trianguloY = Console.ReadLine().Split(' ');
            double ya = double.Parse(trianguloY[0], CultureInfo.InvariantCulture);
            double yb = double.Parse(trianguloY[1], CultureInfo.InvariantCulture);
            double yc = double.Parse(trianguloY[2], CultureInfo.InvariantCulture);

            double p = (xa + xb + xc) / 2.0;
            double AreaX = Math.Sqrt(p * (p - xa) * (p - xb) * (p - xc));

            p = (ya + yb + yc) / 2.0;
            double AreaY = Math.Sqrt(p * (p - ya) * (p - yb) * (p - yc));

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
