using System.Globalization;

namespace EstudoAulaC_60Exercicio {
    internal class Program {
        static void Main(string[] args) {
            ContaBancaria contabancaria = new ContaBancaria();
            Double Deposito;

            Console.Write("Entre o número da conta: ");
            contabancaria.NumeroConta = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            contabancaria.NomeTitular = Console.ReadLine();

            Console.Write("Haverá deposito inicial? S/N ");
            string QuerDepositoInicial = Console.ReadLine();
            if (QuerDepositoInicial == "s" || QuerDepositoInicial == "S") {
                Console.WriteLine("Entre o valor inicial: ");
                 Deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                contabancaria.DepositarValorConta(Deposito);
            }
                Console.WriteLine("Dados da conta:");
                Console.WriteLine(contabancaria);

                Console.WriteLine();

                Console.Write("Entre um valor para depósito: ");
                Deposito = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                contabancaria.DepositarValorConta(Deposito);
                Console.WriteLine("Dados da conta atualizados");
                Console.WriteLine(contabancaria);

                Console.WriteLine();

                Console.Write("Entre um valor para saque:");
                Deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                contabancaria.SacarValorConta(Deposito);
                Console.WriteLine("Dados da conta atualizados");
                Console.WriteLine(contabancaria);



            }
        }
    }

