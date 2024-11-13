using System;

namespace uri1114 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Entre com um valor");

            int senha = int.Parse(Console.ReadLine());

            while (senha != 2002) {
                senha = int.Parse(Console.ReadLine());
                Console.WriteLine("Senha Invalida");
            }

            Console.WriteLine("Acesso Permitido");
        }
    }
}