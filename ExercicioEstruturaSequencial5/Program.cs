using System.Globalization;

namespace ExercicioEstruturaSequencial5 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Entre com o  código da peça, a quantidade,o valor unitário");
            int codpeca1 = int.Parse(Console.ReadLine());

            int Quantidadepecas1 = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double Valorpeca1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com o  código da peça, a quantidade,o valor unitário");
            int codpeca2 = int.Parse(Console.ReadLine());

            int Quantidadepecas2 = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double Valorpeca2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double soma = (Quantidadepecas1 * Valorpeca1) + (Quantidadepecas2 * Valorpeca2) ;
            Console.WriteLine("Valor a pagar: R$ " + soma.ToString("f2",CultureInfo.InvariantCulture));

        }
    }
}
