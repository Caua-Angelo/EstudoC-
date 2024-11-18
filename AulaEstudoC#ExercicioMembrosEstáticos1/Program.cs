using System.Globalization;

namespace AulaEstudoC_ExercicioMembrosEstáticos1 {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Qual a cotação do dolar? ");
            double cotacao = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantos dólares você vai comprar?");
            double quantia = double.Parse(Console.ReadLine());

            double resultado = ConversorDeMoeda.CalculoFinal(quantia, cotacao);

            Console.WriteLine("Valor a ser pago = " + resultado.ToString("f2",CultureInfo.InvariantCulture));
        }
    }
}
