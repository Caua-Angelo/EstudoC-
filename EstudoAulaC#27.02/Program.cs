﻿namespace EstudoAulaC_27._02 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Qual a hora atual?");
            int hora = int.Parse(Console.ReadLine());

            if (hora < 12) {
                Console.WriteLine("Bom dia");
            }
            else if (hora >= 12 && hora < 18) {
                Console.WriteLine("Boa tarde");
            }
            else {
                Console.WriteLine("Boa noite");
            
            }
        }
    }
}