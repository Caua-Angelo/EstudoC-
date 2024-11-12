namespace EstudoAulaC_ExercicioEstruturaCondicional7 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite 2 números com  casa decimal");
            String[] vet = Console.ReadLine().Split(' ');
            double x = double.Parse(vet[0]);
            double y = double.Parse(vet[1]);

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
        }
    }
}
