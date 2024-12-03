using EstudoAulaC_101Exercicio.Entities;
using EstudoAulaC_101Exercicio.Entities.Enum;

namespace EstudoAulaC_101Exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é o Departamento?");
            string deptname = Console.ReadLine();

            Console.WriteLine("Enter worker data: ");

            Console.Write("Name: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Level (Junior/Pleno/Senior)");
            string nivel = Console.ReadLine().ToUpper();
            WorkerLevel level = Enum.Parse<WorkerLevel>(nivel);
            Console.Write("Base salary: ");
            double basesalary = double.Parse(Console.ReadLine());

            Worker worker = new Worker(nome, level, basesalary);

            int n = 0;
            bool tentativa = false;
            while (!tentativa) //enquanto tentativa for negativo ele repetirá oque está abaixo
            {

                Console.WriteLine("Qual a quantidade de contratos?");
                string entrada = Console.ReadLine();

                tentativa = int.TryParse(entrada, out n);//tenta converter o valor da string entrada para um int,se ele falhar o valor de tentativa será negativo oque está dentro
                //se der certo o int n receberá o valor de
            }
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter#{i} contract:");
                Console.Write("Date: ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valueperhour = double.Parse(Console.ReadLine());
                Console.Write("Duration: ");
                int duration = int.Parse(Console.ReadLine());
                HourContract contracts = new HourContract(date, valueperhour, duration);
            }
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");

            string monthAndYear = Console.ReadLine();

            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));
        }
    }
}
 