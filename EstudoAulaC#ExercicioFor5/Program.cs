namespace EstudoAulaC_ExercicioFor5 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Entre com um valor");
            int valor = int.Parse(Console.ReadLine());
            int fat = 1;

            for (int i = 0; i < valor; i++) {

                if (valor > 0) {
                     fat = fatorial(valor);
                }
                else {
                    Console.WriteLine("1");
                }
                static int fatorial(int x) {
                    if (x <= 1) {
                        return 1;
                    }
                    return x * fatorial(x - 1);
                }
            }
                Console.WriteLine(fat);
        }
    }
}
