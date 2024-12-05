namespace EstudoAulaC_ExercicioHerançaPolimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the numbers of employees: ");
            int quantemployees = int.Parse(Console.ReadLine());

            for (int i = 1; i <= quantemployees; i++)

                Console.WriteLine("He is a Outsourced employee?");
            string EmployeeQuestion = Console.ReadLine();
            {
                if (EmployeeQuestion == "y" ||EmployeeQuestion == "Y")
                {
                    Console.Write("Name:");
                    string name = Console.ReadLine();
                    Console.Write("Hours: ");
                    int hours = int.Parse(Console.ReadLine());
                    Console.WriteLine("Value per hour: ");
                    int valueperhour = int.Parse(Console.ReadLine());



                }

            }
        }
    }
}