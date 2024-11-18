using System.Globalization;

namespace EstudoAulaC_46 {
    internal class Program {
        static double Pi = 3.14;
        static void Main(string[] args) {
            Console.WriteLine("Entre com o valor do raio");
            double raio = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double circ = Circunferencia(raio);
            double volume = Volume(raio);

            Console.WriteLine("Circunferencia:" + circ.ToString("f2",CultureInfo.InvariantCulture));
            Console.WriteLine("Volume:" + volume.ToString("f2",CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de Pi " + Pi.ToString("f2",CultureInfo.InvariantCulture));

        }
        static double Circunferencia(double r) {
            return 2.0 * Pi * r;
        }
        static double Volume(double r) {
            return 4.0 / 3.0 * Pi * Math.Pow(r,3);
        }
    }
}
