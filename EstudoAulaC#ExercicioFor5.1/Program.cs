using System;
namespace EstudoAulaC_ExercicioFor5._1 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("entre um número");

            int valor = int.Parse(Console.ReadLine());

            int fat = 1;
            for (int i = 1; i <= valor; i++) {
                fat = fat * i;
            }
                Console.WriteLine(fat);
        }
    }
}