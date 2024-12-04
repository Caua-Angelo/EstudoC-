using EstudoAulaC_108Herança.Entities;

namespace EstudoAulaC_108Herança
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount BAcc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            //UPCASTING

            Account acc1 = BAcc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Ana", 0.0, 0.01);

            //DOWNCASTING

            BusinessAccount acc4 = (BusinessAccount)acc3;
            acc4.loan(100.0);

            if (acc3 is BusinessAccount)
            {

                //BusinessAccount acc5 = (BusinessAccount)acc3;
                BusinessAccount acc5 = acc3 as BusinessAccount;//sintaxe alternativa
                acc5.loan(200.0);
                Console.WriteLine("Loan!");

            }
            if (acc3 is SavingsAccount)
            {
                //SavingsAccount acc5 = (SavingsAccount)acc3;
                SavingsAccount acc5 = acc3 as SavingsAccount;//sintaxe alternativa
                acc5.UpdateBalance();
                Console.WriteLine("Update");
            }
        } }
    }