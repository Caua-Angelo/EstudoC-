

namespace AulaEstudoC_ExercicioMembrosEstáticos1 {
    internal class ConversorDeMoeda {
        static double iof = 0.06;
        public static double CalculoFinal(double quantia,double cotacao) {
        double valor = quantia * cotacao;

            return valor + valor  * iof;
        }
    }
}
