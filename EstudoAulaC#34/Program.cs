namespace EstudoAulaC_34 {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Quantos números inteiros você quer digitar?");

            int numero = int.Parse(Console.ReadLine());

            int soma = 0;
            for (int i = 1; i <= numero; i++) {
                Console.Write("Valor#{0} ",i);
                int valor = int.Parse(Console.ReadLine());
                soma += valor;
            }
            Console.WriteLine("Soma igual a :" + soma);
        }
    }
}