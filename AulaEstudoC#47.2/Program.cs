using AulaEstudoC_47;
using System.Globalization;

namespace EstudoAulaC_46 {
    internal class Program {

        static void Main(string[] args) {
            
            Console.WriteLine("Entre com o valor do raio");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine("Circunferencia:" + circ.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume:" + volume.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de Pi " + Calculadora.Pi.ToString("f2", CultureInfo.InvariantCulture));


        }
    }
}