using EstudoAulaC_ExercícioInterface2.Entities;
using EstudoAulaC_ExercícioInterface2.Services;

namespace EstudoAulaC_ExercícioInterface2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter contract data");
            int contractNumber = int.Parse(Console.ReadLine());

            Console.Write("Date (dd/MM/yyyy): ");
            DateTime data = DateTime.Parse(Console.ReadLine());
            Console.Write("Contract value: ");
            double contractvalue = double.Parse(Console.ReadLine());

            Console.Write("Number of installments: ");
            int installmentsqtt = int.Parse(Console.ReadLine());

            for (int i = 1; i <= installmentsqtt; i++)
            {

            }

        }
    }
}