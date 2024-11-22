using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoAulaC_Exerciciolista {
    internal class Funcionarios {
        public int Id { get; set; }
        public string Name { get; set; }
        public double salary { get; set; }
        public Funcionarios(int id, string name, double salary) { 
            Id = id;
            Name = name;
            salary = salary;
            }
        public Funcionarios() { }
        public double AumentarSalario(double x) {
            return salary *= (x / 100);
        }
        public override string ToString() {
            return "Id: " + Id + ", " + Name + ", " + salary;
        }

    }
}
    


