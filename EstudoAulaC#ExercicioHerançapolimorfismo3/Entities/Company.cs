using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoAulaC_ExercicioHerançapolimorfismo3.Entities
{
    internal class Company : TaxPayer
    {
        public int Workers { get; set; }
        public Company(string name, double anualincome,int workers) : base(name, anualincome)
        {
        }

        public override double TaxesCalculated()
        {
            return
        }
    }
}
