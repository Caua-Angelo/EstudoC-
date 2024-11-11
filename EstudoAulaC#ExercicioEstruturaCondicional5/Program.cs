using System.Globalization;

namespace EstudoAulaC_ExercicioEstruturaCondicional5 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite o código do item e a quantidade na mesma linha");
            string[] numeros = Console.ReadLine().Split(' ');
            int codproduto = int.Parse(numeros[0]);
            int quantidade = int.Parse(numeros[1]);

            double cachorroquente = 4.00;
            double xSalada = 4.50;
            double xBacon = 5.00;
            double torradaSimples = 2.00;
            double Refrigerante = 1.50;


            double Valorfinal = 0;
            if (codproduto == 1) {
                Valorfinal = cachorroquente * quantidade;
            }
            else if (codproduto == 2) {
                Valorfinal = xSalada * quantidade;
            }
            else if (codproduto == 3) {
                Valorfinal = xBacon * quantidade;
            }
            else if (codproduto == 4) {
                Valorfinal = torradaSimples * quantidade;
            }
            else if (codproduto == 5) {
                Valorfinal = Refrigerante * quantidade;
            }
            Console.WriteLine("Total: R$ " + Valorfinal.ToString("f2"), CultureInfo.InvariantCulture);
        }
    }
}
