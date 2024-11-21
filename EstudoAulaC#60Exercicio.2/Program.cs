namespace EstudoAulaC_60Exercicio._2 {
    internal class Program {
        static void Main(string[] args) {

            ContaBancaria contabancaria = new ContaBancaria();

            Console.Write("Entre com o número da conta bancaria: ");
            contabancaria.NumeroConta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            contabancaria.TitularConta = Console.ReadLine();
            Console.Write("Haverá deposito inicial? (sim/não) ");
            string Duvidadeposito = Console.ReadLine();
            if (Duvidadeposito == "sim" || Duvidadeposito == "SIM") {
                contabancaria.DepositarConta();
            }
            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(contabancaria);

            Console.WriteLine();
            
            contabancaria.DepositarConta();
            Console.WriteLine(contabancaria);

            Console.WriteLine();
            contabancaria.SacarConta();

            Console.WriteLine(contabancaria);
        }
    }
}
