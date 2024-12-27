using EstudoAulaC_165.Services;

namespace EstudoAulaC_165
{
    delegate double BinaryNumericOperation(double n1,double n2);
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationService.Sum;
            double result = op(a,b);
           


            //double result = CalculationService.Square(a);
            Console.WriteLine(result);
        }
    }
}
