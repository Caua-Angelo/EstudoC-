namespace EstudoAulaC_38 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Entre com as medidas do triangulo X!");
            string[] trianguloX = Console.ReadLine().Split(' ');
            double xa = double.Parse(trianguloX[0]);
            double xb = double.Parse(trianguloX[1]);
            double xc = double.Parse(trianguloX[2]);

            Console.WriteLine("Entre com as medidas do triangulo Y!");
            string[] trianguloY = Console.ReadLine().Split(' ');
            double Ya = double.Parse(trianguloX[0]);
            double Yb = double.Parse(trianguloX[1]);
            double Yc = double.Parse(trianguloX[2]);

        }

        static int CalcularAreaTriangulo(double x, double y, double z) {
            double p = (x + y + z) / 2;
            double Area = Math.Sqrt((p - x) * (p - y) * (p - y));


        }
    }
}