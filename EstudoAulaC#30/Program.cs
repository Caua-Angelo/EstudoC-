namespace EstudoAulaC_30 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite 3 valores");
            string[] vet = Console.ReadLine().Split(' ');

            int num1 = int.Parse(vet[0]);
            int num2 = int.Parse(vet[1]);
            int num3 = int.Parse(vet[2]);

            double resultado = Maior(num1,num2,num3);
            double resultado2 = Maior(1, 7, 4);//pode inclusive adicionar os números diretamente

            Console.WriteLine("Maior = " + resultado);
        }
        static int Maior(int a, int b, int c) {
            int m;
            if (a > b && a > c) {
                m = a;
            }
            else if (b > a && b > c) {
                m = b;
            }
            else { 
             m = c;
            }
            return m;
        }
    }
}