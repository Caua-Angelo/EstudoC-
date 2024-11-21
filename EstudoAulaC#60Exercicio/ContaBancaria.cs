

namespace EstudoAulaC_60Exercicio {
    internal class ContaBancaria {

        private int NumeroConta { get; set; }
        private string NomeTitular { get; set; }
        private double ValorConta { get; set; }

        /*/public ContaBancaria(int numeroconta,string nometitular,double valorconta) {
            NumeroConta = numeroconta;
            NomeTitular = nometitular;
            ValorConta = valorconta;
        }*/
        public void DepositarValorConta(double x) {
            ValorConta += x; {
            }
        }
        public void SacarValorConta(double x) {
            ValorConta =(ValorConta - x )- 5.00;
        }
        public override string ToString() {
            return "Conta " + NumeroConta + "," + "Titular: " + NomeTitular + "," + "Saldo: " + ValorConta.ToString("f2");
        }


    }
}
