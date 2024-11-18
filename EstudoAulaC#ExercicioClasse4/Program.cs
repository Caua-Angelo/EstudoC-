namespace EstudoAulaC_ExercicioClasse4 {
    internal class Program {
        static void Main(string[] args) {
            Funcionario funcionario1 = new Funcionario();

            Console.WriteLine("Imprima os dados do funcionário");
            Console.Write("Nome: ");
            funcionario1.nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            funcionario1.SalarioBruto = double.Parse(Console.ReadLine());
            Console.WriteLine("Imposto");
            funcionario1.imposto = double.Parse(Console.ReadLine());

        }
    }
}
