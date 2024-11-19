

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
        public double DepositoInicial(double x) {
            return ValorConta += x; {


            }
        }

        public void AumentarValorConta(double x) {
            ValorConta += x;
        }
        public override string ToString() {
            return "Conta " + NumeroConta + "," + "Titular" + NomeTitular + "," + "Saldo: " + ValorConta;
        }


    }
}
