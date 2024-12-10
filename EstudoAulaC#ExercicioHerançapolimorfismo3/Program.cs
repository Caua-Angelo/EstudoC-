namespace EstudoAulaC_ExercicioHerançapolimorfismo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of tax payers: ");
            int Quantitytaxpayers = int.Parse(Console.ReadLine());
            for (int i = 1; i <= Quantitytaxpayers; i++)
                Console.WriteLine("Individual or Company?");
            string IndividualCompany = Console.ReadLine();
            if (IndividualCompany == "i" || IndividualCompany == "I")
            {

            }
            else if (IndividualCompany == "c" || IndividualCompany == "C")
            {

            }
        }
    }
}
