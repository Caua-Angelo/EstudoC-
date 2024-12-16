using EstudoAulaExerciciointerfaces.Entities;

namespace EstudoAulaExerciciointerfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter rental data");
            Console.Write("Car Model: ");
            string carModel = Console.ReadLine();

            Console.Write("Pickup (dd/MM/yyyy hh:mm)");
            DateTime start = DateTime.Parse(Console.ReadLine());

            Console.Write("Return (dd/MM/yyyy hh:mm)");
            DateTime finish = DateTime.Parse(Console.ReadLine());

            Console.Write("Enter price per hour: ");
            double pricePerHour = double.Parse(Console.ReadLine());

            Console.Write("Enter price per day: ");
            double priceperDay = double.Parse(Console.ReadLine());

            Rental rental = new Rental(carModel, start, finish, pricePerHour, priceperDay);

            rental.Finalpayment();

            Console.WriteLine(rental);

        }
    }
}
