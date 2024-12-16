using EstudoAulaExerciciointerfaces.Entities;
using EstudoAulaExerciciointerfaces.Services;

namespace EstudoAulaExerciciointerfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter rental data");
            Console.Write("Car Model: ");
            string model = Console.ReadLine();

            Console.Write("Pickup (dd/MM/yyyy hh:mm)");
            DateTime start = DateTime.Parse(Console.ReadLine());

            Console.Write("Return (dd/MM/yyyy hh:mm)");
            DateTime finish = DateTime.Parse(Console.ReadLine());

            Console.Write("Enter price per hour: ");
            double pricePerHour = double.Parse(Console.ReadLine());

            Console.Write("Enter price per day: ");
            double priceperDay = double.Parse(Console.ReadLine());

            CarRental carRental = new CarRental(start, finish,new Vehicle(model));

            RentalService rentalservice = new RentalService(pricePerHour, priceperDay);

            rentalservice.ProcessInvoice(carRental);

            Console.WriteLine("Invoice");

            Console.WriteLine(carRental.Invoice);
            

        }
    }
}
