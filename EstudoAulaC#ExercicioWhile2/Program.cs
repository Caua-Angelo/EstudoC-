namespace EstudoAulaC_ExercicioWhile2 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Entre 2 valores");
            String[] vet = Console.ReadLine().Split(' ');

            int x = int.Parse(vet[0]);
            int y = int.Parse(vet[1]);

            while (x != 0 && y != 0) {
                if (x > 0 && y > 0) {
                    Console.WriteLine("Q1");
                }
                else if (x > 0 && y < 0) {
                    Console.WriteLine("Q4");
                }
                else if (x < 0 && y > 0) {
                    Console.WriteLine("Q2");
                }
                else if (x < 0 && y < 0) {
                    Console.WriteLine("Q3");
                }
                else if (x == 0 && y == 0) {
                    Console.WriteLine("Origem");
                }
                break;
            }
        }
    }
}
