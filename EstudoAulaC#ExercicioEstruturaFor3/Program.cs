using System.Globalization;

namespace EstudoAulaC_ExercicioFor3 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Insira o numero de casos que virão a seguir");
            int quantCasos = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            for (int i = 0; i < quantCasos; i++) {

                string[] vet = Console.ReadLine().Split(' ');
                if (vet.Length != 3) {
                    Console.WriteLine("Entrada inválida. Por favor, insira três números separados por espaço.");
                    continue;
                }
                double a = double.Parse(vet[0],CultureInfo.InvariantCulture);
                double b = double.Parse(vet[1],CultureInfo.InvariantCulture);
                double c = double.Parse(vet[2],CultureInfo.InvariantCulture);

                double media = (a * 2.0 + b * 3.0 + c * 5.0) / 10.0;//os números recebidos são multiplicados por seu
                                                                    //peso  e depois divididos pela soma dos pesos nesse caso 10
                Console.WriteLine(media.ToString("f1",CultureInfo.InvariantCulture));
            }

        }
    }
}
