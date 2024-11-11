namespace EstudoAulaC_ExercicioEstruturaCondicional3 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Entre com 2 valores:");

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            if (num1 % num2 == 0 || num2 % num1 == 0) {
                Console.WriteLine("são multiplos");
            }
            else  {
                Console.WriteLine("Não são multiplos");
            }
        }
    }
}