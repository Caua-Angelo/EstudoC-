namespace EstudoAulaC_87Ternário {
    internal class Program {
        static void Main(string[] args) {

            double preco = double.Parse(Console.ReadLine());

            double desconto = (preco < 20.0) ?preco * 0.1: preco * 0.05 ;
            Console.WriteLine(desconto);

        }
    }
}
