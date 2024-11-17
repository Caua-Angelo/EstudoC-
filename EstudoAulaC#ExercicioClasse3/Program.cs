using System.Globalization;

namespace EstudoAulaC_ExercicioClasse3 {
    internal class Program {
        static void Main(string[] args) {
            Retangulo retangulo1 = new Retangulo();

            Console.WriteLine("Seja bem vindo ao calculo do Retangulo");

            Console.WriteLine("Insira A largura");
            retangulo1.largura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Insira A altura");
            retangulo1.Altura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double area = retangulo1.Area();
            Console.WriteLine("Area: " + area.ToString("f2",CultureInfo.InvariantCulture));
            double perimetro = retangulo1.perimetro();
            Console.WriteLine("Perimetro: "+ perimetro.ToString("f2",CultureInfo.InvariantCulture));
            double diagonal = retangulo1.diagonal();
            Console.WriteLine("Diagonal: "+ diagonal.ToString("f2",CultureInfo.InvariantCulture));
        }
    }
}
