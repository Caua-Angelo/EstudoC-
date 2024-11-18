using System.Globalization;

namespace EstudoAulaC_ExercicioClasse5 {
    internal class Program {
        static void Main(string[] args) {
            Aluno aluno1 = new Aluno();

            Console.Write("Qual o nome do aluno: ");
            aluno1.nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno");
            aluno1.nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno1.nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno1.nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Nota final: " + aluno1.NotaFinal().ToString("F2"), CultureInfo.InvariantCulture);
            if (aluno1.AprovadoOuReprovado()) {
                Console.WriteLine("Aprovado");
            }
            else {
                Console.WriteLine("Reprovado");
                Console.WriteLine("Faltaram " + aluno1.NotaRestante().ToString("f2")+ "Pontos");
            }
        }
    }
}
