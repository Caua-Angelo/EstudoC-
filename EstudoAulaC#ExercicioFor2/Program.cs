namespace EstudoAulaC_ExercicioFor2 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Quanto números você vai digitar?");
            int quantidade = int.Parse(Console.ReadLine());

            int dentro = 0;
            int fora = 0;

            for (int i = 0; i < quantidade; i++) {
                int numero = int.Parse(Console.ReadLine());
                if (numero >= 10 && numero <= 20) {
                    dentro++;
                }
                else {
                    fora++;
                }
            }
                Console.WriteLine(dentro+ " in");
                Console.WriteLine(fora+ " out");
        }
    }
}
