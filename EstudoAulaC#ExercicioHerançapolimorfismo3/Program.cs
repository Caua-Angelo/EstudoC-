using EstudoAulaC_ExercicioHerançapolimorfismo3.Entities;
using System;

namespace EstudoAulaC_ExercicioHerançapolimorfismo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> taxPayers = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int Quantitytaxpayers = int.Parse(Console.ReadLine());

            for (int i = 1; i <= Quantitytaxpayers; i++)
            {

                Console.Write("Individual or Company?");
                string IndividualCompany = Console.ReadLine();

                if (IndividualCompany == "i" || IndividualCompany == "I")
                {
                    Console.Write("Nome: ");
                    string name = Console.ReadLine();
                    Console.Write("Anual Income: ");
                    double anualincome = double.Parse(Console.ReadLine());
                    Console.Write("Health Expeditures: ");
                    double healthexpeditures = double.Parse(Console.ReadLine());

                    taxPayers.Add(new Individual(name, anualincome, healthexpeditures));
                }
                else if (IndividualCompany == "c" || IndividualCompany == "C")
                {
                    Console.Write("Nome: ");
                    string name = Console.ReadLine();
                    Console.Write("Anual Income: ");
                    double anualincome = double.Parse(Console.ReadLine());
                    Console.Write("Number of employees?");
                    int workersnumbers = int.Parse(Console.ReadLine());

                    taxPayers.Add(new Company(name, anualincome, workersnumbers));
                }
            }
            double totaltaxes = 0;
            foreach (TaxPayer taxpayer in taxPayers)
            {
                Console.Write(taxpayer.Name + ": $" + taxpayer.TaxesCalculated().ToString("f2"));
                totaltaxes += taxpayer.TaxesCalculated();
                Console.WriteLine();
            }
                Console.Write("TOTAL TAXES: " + totaltaxes);
        }
    }
}