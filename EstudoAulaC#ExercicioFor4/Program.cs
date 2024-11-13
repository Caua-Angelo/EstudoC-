using System.Globalization;

namespace EstudoAulaC_ExercicioFor4 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite a quantidade de divisões que você deseja fazer");
            int quantidade = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            for (int i = 0; i < quantidade; i++) {
                string[] vet = Console.ReadLine().Split(' ');
                int num0 = int.Parse(vet[0]);
                int num1 = int.Parse(vet[1]);

                double divisao = 0;
                double
                if (num1 > 0) {
                    divisao = num1 / num0;
                   
                }
                else if (num1 == 0) {
                    Console.WriteLine("Divisão impossivel");
                }
                Console.WriteLine(divisao);
            }
        }
    }
}
