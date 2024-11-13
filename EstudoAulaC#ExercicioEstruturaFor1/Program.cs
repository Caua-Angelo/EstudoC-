namespace EstudoAulaC_ExercicioFor1 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite um valor");
            int valor = int.Parse(Console.ReadLine());
            int impares = 1;

            for (int i = 1; i <= valor; i++) {
                if (i % 2 != 0) {
                    Console.WriteLine(i);
                

                }
            }
        }
    }
}
