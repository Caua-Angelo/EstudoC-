using System.Threading.Channels;

namespace EstudoAulaC_27 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine();
            int x = int.Parse(Console.ReadLine());

            if (x % 2 == 0) {
                Console.WriteLine("Par");
            }
            else {
                Console.WriteLine("Impar");

            }
        }
    }
}
