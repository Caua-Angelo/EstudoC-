using System.Globalization;

namespace EstudoAula18C_Exercicio {
    internal class Program {
        static void Main(string[] args) {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double preco3 = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine("{0}, cujo preço é $ {1:F2}", produto1, preco1);
            Console.WriteLine("{0}, cujo preço é $ {1:F2}",produto2, preco2);

            Console.WriteLine("Registro: {0} anos de idade, Código {1} e gênero : {2}",idade,codigo,genero);
            Console.WriteLine(preco3.ToString("F8"));
            Console.WriteLine(preco3.ToString("F3"));
            Console.WriteLine(preco3.ToString("F3",CultureInfo.InvariantCulture));
    
        } 
    }
} 