using System.Globalization;

namespace EstudoAulaC_42 {
    internal class Program {
        static void Main(string[] args) {

            Produto produto = new Produto();
            Console.WriteLine("Insira os dados do produto em estoque:");
            Console.Write("nome: ");
            produto.Nome = Console.ReadLine();
            Console.Write("preco: ");
            produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("quantidade: ");
            produto.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Dados do produto " + produto);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            produto.AdicionarProdutos((qte));
            Console.WriteLine("Dados atualizados" + produto);

            Console.WriteLine();
            Console.WriteLine("Digite o número de produtos a ser removido do estoque");
            int qtremove = int.Parse((Console.ReadLine()));
            produto.RemoverProdutos((qtremove));
            Console.WriteLine("Dados atualizados" + produto);

        }
    }
}
