namespace EstudoAulaC_ExercicioEstruturaCondicional2 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Entre um número");

            int numero = int.Parse(Console.ReadLine());
            if (numero % 2 == 0) {
                Console.WriteLine("Par");
            }
            else {
                Console.WriteLine("Impar");
            }
        }
    }
}
