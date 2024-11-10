using System.Globalization;

namespace EstudoAulaC_ExercicioEstruturaSequencial4 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite seu ID de funcionário: ");
            int IdFuncionario = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite seu número de horas trabalhadas: ");
            int Horastrabalhadas = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o valor que você recebe por hora: ");
            double Valorhora = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture) ;
            Console.WriteLine("Id  de funcionário: " + IdFuncionario);
            double salario = Horastrabalhadas * Valorhora;
            Console.WriteLine("Salário: U$"+ salario.ToString("f2",CultureInfo.InvariantCulture));
        }
    }
}
