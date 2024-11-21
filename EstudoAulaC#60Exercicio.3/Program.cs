namespace EstudoAulaC_60Exercicio._2 {
    internal class Program {
        static void Main(string[] args) {
            ContaBancaria contabancaria;

            Console.Write("Entre com o número da conta bancaria: ");
            int Numeroconta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titularconta = Console.ReadLine();
            Console.Write("Haverá deposito inicial? (sim/não) ");
            string Duvidadeposito = Console.ReadLine();

            if (Duvidadeposito == "sim" || Duvidadeposito == "SIM") {
                double deposito = double.Parse(Console.ReadLine());
                contabancaria = new ContaBancaria(Numeroconta, titularconta, deposito);
            }
            else {
                contabancaria = new ContaBancaria(Numeroconta, titularconta);
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
}