using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoAulaC_Exerciciolista {
    internal class Funcionarios {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public Funcionarios(int id, string name, double salary) { //cria um construtor com o Id nome e salário
            Id = id;
            Name = name;
            Salary = salary;
            }
        public Funcionarios() { }//cria um construtor que é vazio
        public void AumentarSalario(double porcentagem) {//aumenta o salário na porcentagem do número que é recebido
             Salary += Salary * (porcentagem / 100.0);
        }
        public override string ToString() {//formata a classe para mostrar os atributos de forma mais agradável
            return "Id: " + Id + ", " + Name + ", " + Salary;
        }

    }
}
    


