using System.Globalization;

namespace EstudoAulaC_Classe2 {
    internal class Program {
        static void Main(string[] args) {

            Funcionario funcionario1 = new Funcionario();
            Funcionario funcionario2 = new Funcionario();

            Console.WriteLine("Entre com o nome do primeiro funcionário");
            funcionario1.nome = Console.ReadLine();
            Console.WriteLine("Agora o salario");
            funcionario1.salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com o nome do primeiro funcionário");
            funcionario2.nome = Console.ReadLine();
            Console.WriteLine("Agora o salario");
            funcionario2.salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double mediasalarial = (funcionario1.salario + funcionario2.salario) / 2;
            Console.WriteLine("A media salarial dos funcionarios é : " + mediasalarial.ToString("f2"),CultureInfo.InvariantCulture);
        }
    }
}
