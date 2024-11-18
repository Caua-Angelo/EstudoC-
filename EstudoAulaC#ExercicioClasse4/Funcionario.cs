using System.Globalization;
using System;

namespace EstudoAulaC_ExercicioClasse4 {
    internal class Funcionario {
        public string nome;
        public double SalarioBruto;
        public double imposto;
        public double SalarioLiquido() {
            return SalarioBruto - imposto;
        }
        public void AumentarSalario(double x) {
            SalarioBruto = SalarioBruto + (SalarioBruto * x / 100);
        }
        public override string ToString() {
            return nome 
                + ",Salário: " 
                + SalarioLiquido().ToString("f2",CultureInfo.InvariantCulture);
        }
    }
}

