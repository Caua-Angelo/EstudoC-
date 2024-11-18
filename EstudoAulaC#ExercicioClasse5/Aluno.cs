
namespace EstudoAulaC_ExercicioClasse5 {
    internal class Aluno {
        public double nota1;
        public double nota2;
        public double nota3;
        public string nome;

        public double NotaFinal() {
            return (nota1 + nota2 + nota3);
        }
        public bool AprovadoOuReprovado() {
            if (NotaFinal() >= 60) {
                return true;
            }
            else {
                return false;
            }
        }
        public double NotaRestante() {
            if (AprovadoOuReprovado()) {
                return 0.0;
            }
            else {
                return 60 - NotaFinal();
            }
        }
    }
}



