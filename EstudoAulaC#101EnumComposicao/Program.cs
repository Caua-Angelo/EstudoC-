using EstudoAulaC_101EnumComposicao.Entities;
using EstudoAulaC_101EnumComposicao.Entities.Enum;
using System.Diagnostics.Contracts;
using System.Globalization;

namespace EstudoAulaC_101EnumComposicao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string deptName = Console.ReadLine();

            Console.WriteLine("Enter worker data: ");
            
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("level (Junior/Midlevel/Senior) ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.Write("Base Salary");
            double basesalary = double.Parse(Console.ReadLine());

            Department dept = new Department(deptName);
            Worker worker = new Worker(name, level, basesalary, dept);

            Console.WriteLine("How many contracts for this worker?:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i < n; i++)
            {
                Console.Write("Enter " + i + "#" + "Contract data: ");

                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());
                
                Console.Write("Duration (hours): ");
                int hour = int.Parse(Console.ReadLine());
                
                HourContract contract = new HourContract(date,valuePerHour,hour);
                worker.AddContract(contract);
            }
            Console.WriteLine();
            Console.WriteLine("Enter month and year to calculate income (MM/YYYY):");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine("Name " + worker.Name);
            Console.WriteLine("Department " + worker.Department.Name);
            Console.WriteLine("Income for :" + monthAndYear+ ": " + worker.Income(year,month).ToString("f2"),CultureInfo.InvariantCulture);
        }
    }
}
