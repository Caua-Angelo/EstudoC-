using EstudoAulaExerciciointerfaces.Entities;

namespace EstudoAulaExerciciointerfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Rental> rentals = new List<Rental>();

            Console.WriteLine("enter rental data");
            Console.Write("Car Model: ");
            string carModel = Console.ReadLine();
            Console.Write("Pickup");
            DateTime pickup = DateTime.Parse(Console.ReadLine());

            Console.Write("Return");
            DateTime Return = DateTime.Parse(Console.ReadLine());

            TimeSpan duracao = (pickup - Return);

            Console.Write("Enter price per hour: ");
            double pricePerHour = double.Parse(Console.ReadLine());

            Console.Write("Enter price per day: ");
            double priceperDay = double.Parse(Console.ReadLine());

            rentals.Add(new Rental(carModel, pickup, Return, pricePerHour, priceperDay));


        }
    }
}
