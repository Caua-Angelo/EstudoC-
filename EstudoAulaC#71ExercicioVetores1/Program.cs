namespace EstudoAulaC_71ExercicioVetores1 {
    internal class Program {
        static void Main(string[] args) {

            Quartos[] vect = new Quartos[10];

            Console.WriteLine("Quantos quartos serão alugados?");
            int quantidadeQuartos = int.Parse(Console.ReadLine());//recebe uma variável que define a quantidade de quartos que serão ocupados

            for (int i = 1; i <= quantidadeQuartos; i++) {
                //recebe as informações de nome e email da classe Quartos e coloca no quarto pedido pelo cliente
                Console.WriteLine();
                Console.WriteLine("Aluguel # " + i + ":");
                Console.Write("nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                //cria uma nova instancia da classe Quartos e coloca o nome e email dentro do espaço escolhido pelo cliente(nesse caso o quarto)
                vect[quarto] = new Quartos(nome, email);
            }
            Console.WriteLine();
            Console.WriteLine("Quartos ocupados: ");
            for (int i = 0; i < 10; i++) {
                if (vect[i] != null) {// se o vetor não for nulo
                    Console.WriteLine(i + ":" + vect[i]);//mostre o vetor
                }
            }
        }
    }
}