using EstudoAulaC_ExercicioAbrangenteCopilot.Entities;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace EstudoAulaC_ExercicioAbrangenteCopilot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valorindicado = 0;
            int n = 0;

            Console.WriteLine("Quantos carros você deseja registrar?");
            while (!int.TryParse(Console.ReadLine(), out valorindicado))
            {
                Console.WriteLine("Digite um valor valido: ");
            }
            n = valorindicado;
            Console.WriteLine("QTD Carros => " + n);

            Carro[] vect = new Carro[n];
            List<Livro> lista = new List<Livro>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Digite as informações do carro({i})");
                Console.Write("Marca: ");
                String marca = Console.ReadLine().ToUpper();

                Console.Write("Modelo: ");
                string modelo = Console.ReadLine().ToUpper();

                Console.Write("Ano: ");
                int ano = int.Parse(Console.ReadLine());

                Console.Write("Cor: ");
                string cor = Console.ReadLine().ToUpper();
                Console.WriteLine();

                vect[i - 1] = new Carro(marca, modelo, cor, ano);
            }
            string resposta;
            do
            {
                Console.WriteLine("Digite as informações do livro: ");
                Console.Write("Título: ");
                string titulo = Console.ReadLine().ToUpper();

                Console.Write("Autor: ");
                string autor = Console.ReadLine().ToUpper();

                Console.Write("Ano de publicação: ");
                int anopublicacao = int.Parse(Console.ReadLine());

                lista.Add(new Livro(titulo, autor, anopublicacao));

                Console.WriteLine("Deseja adicionar outro livro? (s/n)");
                resposta = Console.ReadLine().ToUpper();
            }
            while (resposta == "s");
            foreach (Livro livros in lista)
            {
                Console.WriteLine(livros);
            }
            Console.WriteLine("Digite a Marca do carro para pesquisa: ");
            string marcacarro = Console.ReadLine().ToUpper();
            Console.WriteLine("Digite o Modelo do carro para pesquisa: ");
            string modelocarro = Console.ReadLine().ToUpper();

            foreach (Carro carro in vect)
            {
                if (carro.Marca == marcacarro && carro.Modelo == modelocarro)
                {
                    Console.WriteLine(carro);
                }
            }

        }
    }
}