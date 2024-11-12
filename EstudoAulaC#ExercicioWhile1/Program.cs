namespace EstudoAulaC_ExercicioWhile1 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Entre um valor");
            int senha= 0;
            while (senha != 2002) {
                senha = int.Parse(Console.ReadLine());
                if (senha != 2002) { 
                Console.WriteLine("Senha invalida");
            }
            }
            Console.WriteLine("Acesso permitido");
        }
    }
}
