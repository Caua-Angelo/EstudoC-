using System.ComponentModel.Design;

namespace EstudoAulaC_ExercicioWhile3 {
    internal class Program {
        static void Main(string[] args) {
            int alcool = 0;
            int Gasolina = 0;
            int Diesel = 0;

            int valor = 0;

            Console.WriteLine("Digite um valor");


            while (valor != 4) {

            valor = int.Parse(Console.ReadLine());

                if (valor == 1) {
                    
                    ++alcool;
                }
                else if (valor == 2) {
                    
                    ++Gasolina;
                }
                else if (valor == 3) {
                    
                    ++Diesel;
                }
                else if (valor == 4) {
                    Console.WriteLine("Muito obrigado");
                    Console.WriteLine("Alcool: " + alcool);
                    Console.WriteLine("Gasolina: " + Gasolina);
                    Console.WriteLine("Diesel: " + Diesel);
                }

            }
        }
    }
}
