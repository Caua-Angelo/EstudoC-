using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoAulaC_101Exercicio.Entities
{
    internal class Department
    {
        public string DeptName { get; set; }
        public Department(string deptname) { DeptName = deptname; }
    }
}
