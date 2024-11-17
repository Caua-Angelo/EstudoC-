namespace EstudoAulaC_ExercicioClasse1 {
    internal class Program {
        static void Main(string[] args) {


            Pessoa pessoa1 = new Pessoa();
            Pessoa pessoa2 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa:");

            Console.WriteLine("Nome: ");
            pessoa1.Nome = Console.ReadLine();
            Console.WriteLine("Idade: ");
            pessoa1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");
            Console.WriteLine("Nome: ");
            pessoa2.Nome = Console.ReadLine();
            Console.WriteLine("Idade");
            pessoa2.Idade = int.Parse(Console.ReadLine());

            if (pessoa1.Idade > pessoa2.Idade) {
                Console.WriteLine(pessoa1.Nome + " é o mais velho");
            }
            else {
                Console.WriteLine(pessoa2.Nome + " é o mais velho");
            }
        }
    }
}
