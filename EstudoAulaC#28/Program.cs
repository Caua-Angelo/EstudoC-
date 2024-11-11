namespace EstudoAulaC_28 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("");
            double preco = double.Parse(Console.ReadLine());
            double desconto = 0.0;

            if (preco > 100) {
                 desconto = preco * 0.1;

            }
            Console.WriteLine(desconto);
        }
    }
}
