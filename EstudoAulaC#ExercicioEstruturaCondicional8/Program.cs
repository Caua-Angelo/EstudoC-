using System.Globalization;

namespace EstudoAulaC_ExercicioEstruturaCondicional8 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Entre seu salário!");
          
            double salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double imposto;

            if (salario <= 2000) {
                imposto = 0.0;
            }
            else if (salario <= 3000.0) {
                imposto = (salario - 2000.0) * 0.08;
                //Cálculo: Subtrai 2000 do salário para encontrar a parte tributável e aplica a taxa de 8 %.
            }
            else if (salario <= 4500.0) {
                imposto = (salario - 3000.0) * 0.18 + 1000.0 * 0.08;
                //Cálculo: Subtrai 3000 do salário para encontrar a parte tributável a
                //18% e adiciona o imposto fixo de 8% sobre os primeiros 1000 (ou seja, 1000 * 0.08).
            }
            else {
                imposto = (salario - 4500.0) * 0.28 + 1500 * 0.18 + 1000 * 0.08;
                //Subtrai 4500 do salário para encontrar a parte tributável a 28%, adiciona o imposto fixo de 18% sobre os 1500
                //(ou seja, 1500 * 0.18) e o imposto fixo de 8% sobre os primeiros 1000 (ou seja, 1000 * 0.08).
            }
            if (imposto == 0.0) {
                Console.WriteLine("Isento");
            }
            else {
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }


        }
    }
}
