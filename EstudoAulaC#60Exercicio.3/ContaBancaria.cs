using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoAulaC_60Exercicio._2 {
    internal class ContaBancaria {
        public int NumeroConta { get; private set; }
        public string TitularConta { get; set; }
        public double ValorConta { get; private set; }

        public ContaBancaria(int numeroconta, string titularconta) {
            NumeroConta = numeroconta;
            titularconta = titularconta;
        }
        public ContaBancaria(int numeroconta, string titularconta, double valorconta) : this(numeroconta,titularconta) {
            ValorConta = valorconta;
        }
        public void DepositarConta() {
            Console.Write("Entre um valor para depósito: ");
            double ValorDeposito = double.Parse(Console.ReadLine());
            ValorConta += ValorDeposito;
        }
        public void SacarConta() {
            Console.Write("Entre um valor para saque: ");
            double ValorSacar = double.Parse(Console.ReadLine());
            ValorConta = (ValorConta - ValorSacar) - 5;
        }
        public override string ToString() {
            return "Conta " + NumeroConta + ", " + "Titular: " + TitularConta + "," + "Saldo: $ " + ValorConta.ToString("f2");
        }
    }
}


