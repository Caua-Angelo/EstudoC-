namespace EstudoAulaC_ExercicioEstruturaSequencial3 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite 4 valores para ver a diferença entre eles");

            int numero1 = int.Parse(Console.ReadLine());
            int numero2 = int.Parse(Console.ReadLine());
            int numero3 = int.Parse(Console.ReadLine());
            int numero4 = int.Parse(Console.ReadLine());

            int diferenca = numero1 * numero2 - (numero3 * numero4) ;
            Console.WriteLine(diferenca);
        }
    }
}
