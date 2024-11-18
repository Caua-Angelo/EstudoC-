
namespace EstudoAulaC_ExercicioClasse3 {
    internal class Retangulo {
        public double largura;
        public double Altura;

        public double Area() {
            return largura * Altura;
        }
        public double perimetro() {
            return (largura + Altura) * 2;
        }
        public double diagonal() {
            return Math.Sqrt(Math.Pow(largura, 2) + (Math.Pow(Altura, 2)));
        }
    
    }

}
