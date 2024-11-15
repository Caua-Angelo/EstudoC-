namespace EstudoAulaC_TreinoFuncao2 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Insira um valor para ser calculado o fatorial");
            int numero = int.Parse(Console.ReadLine());

            int resultado;
            if (numero < 13) {
                resultado = Fatorial(numero);
                Console.WriteLine("Fatorial de " + numero + " é " + resultado);
            }
            else {
                Console.WriteLine("O Numero é grande demais para o tipo INT suportar,digite um número menor");
            }
            static int Fatorial(int x) {
                int fat = 1;
                for (int i = 1; i <= x; i++) {
                    fat = fat * i;
                }
                return fat;
            }
        }
    }
}
