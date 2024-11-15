using System.Runtime.InteropServices;

namespace EstudoAulaC_TreinoFuncao3 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Entre um número");
            int numero = int.Parse(Console.ReadLine);


            static boll primo(int n) {
                if (n == 0) return false;
                if (n == 2 || n == 3) return true;
                if (n % 2 == 0 || n % 3 == 0) return false;
            }
        }
    }
}