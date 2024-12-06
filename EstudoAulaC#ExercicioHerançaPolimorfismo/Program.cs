using EstudoAulaC_ExercicioHerançaPolimorfismo.Entities;

namespace EstudoAulaC_ExercicioHerançaPolimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the numbers of employees: ");
            int quantemployees = int.Parse(Console.ReadLine());
            //criação das listas
            List<Employee> employees = new List<Employee>();
            //List<OutsourcedEmployee> outsourcedEmployees = new List<OutsourcedEmployee>();

            for (int i = 1; i <= quantemployees; i++)
            {
                Console.WriteLine("Employee " + i + "# Data: ");
                Console.Write("He is a Outsourced employee? ");
                string EmployeeQuestion = Console.ReadLine();
                {
                    if (EmployeeQuestion == "y" || EmployeeQuestion == "Y")
                    {
                        Console.Write("Name:");
                        string name = Console.ReadLine();
                        Console.Write("Hours: ");
                        int hours = int.Parse(Console.ReadLine());
                        Console.WriteLine("Value per hour: ");
                        double valueperhour = double.Parse(Console.ReadLine());
                        Console.WriteLine("Additional charge: ");
                        double additionalcharge = double.Parse(Console.ReadLine());

                        employees.Add(new OutsourcedEmployee(name, hours, valueperhour, additionalcharge));
                    }
                    else if (EmployeeQuestion == "n" || EmployeeQuestion == "N")
                    {
                        Console.Write("Name:");
                        string name = Console.ReadLine();
                        Console.Write("Hours: ");
                        int hours = int.Parse(Console.ReadLine());
                        Console.WriteLine("Value per hour: ");
                        double valueperhour = double.Parse(Console.ReadLine());
                        employees.Add(new Employee(name, hours, valueperhour));
                    }
                }
            }
                    foreach (Employee employee in employees)
                    {
                        Console.WriteLine(employee);
                    }
        }
    }
}