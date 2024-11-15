namespace EstudoAulaC_Treinofuncao4 {
     class Program {
        static void Main(string[] args) {
            Console.WriteLine("Entre 3 notas");
            string[] valores = Console.ReadLine().Split(' ');
            double nota1 = double.Parse(valores[0]);
            double nota2 = double.Parse(valores[1]);
            double nota3 = double.Parse(valores[2]);

            Console.WriteLine("Entre 3 pesos");
            string[] pesos = Console.ReadLine().Split(' ');
            double peso1 = double.Parse(pesos[0]);
            double peso2 = double.Parse(pesos[1]);
            double peso3 = double.Parse(pesos[2]);

            double mediaPonderada= CalcularMediaPonderada(nota1,nota2,nota3,peso1,peso2,peso3);
            Console.WriteLine("A media ponderada é: " + mediaPonderada.ToString("f1"));

            static double CalcularMediaPonderada(double nota1,double nota2,double nota3,double peso1,double peso2,double peso3)  {
                double somaProdutos = (nota1 * peso1) + (nota2 * peso2) + (nota3 * peso3);
                double somaPesos = peso1 + peso2 + peso3;
                return somaProdutos / somaPesos;
            }
        }
    }
}
