using System.Globalization;
namespace EstudoAulaC_ExercicioClasse4 {
    internal class Program {
        static void Main(string[] args) {
            Funcionario funcionario1 = new Funcionario();

            Console.WriteLine("Digite os dados do funcionário");
            Console.Write("Nome: ");
            funcionario1.nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            funcionario1.SalarioBruto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            funcionario1.imposto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine(funcionario1);
            Console.Write("Digite a porcentagem do salário a ser aumentada: ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            funcionario1.AumentarSalario(porcentagem);
            Console.WriteLine(funcionario1);
            
        }
    }
}
