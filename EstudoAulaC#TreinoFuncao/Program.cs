using System.Xml;

namespace EstudoAulaC_TreinoFuncao {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Insira 2 valores");
            string[] numeros = Console.ReadLine().Split(' ');
            int num1 = int.Parse(numeros[0]);
            int num2 = int.Parse(numeros[1]);

            Console.WriteLine(soma(num1,num2));
            static int soma(int x, int y) {
                return x + y;
            }
        }
    }
}
