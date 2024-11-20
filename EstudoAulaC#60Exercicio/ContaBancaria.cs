

namespace EstudoAulaC_60Exercicio {
    internal class ContaBancaria {

        public int NumeroConta { get; set; }
        public string NomeTitular { get; set; }
        public double ValorConta { get; set; }

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
