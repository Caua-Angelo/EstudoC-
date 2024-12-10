using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoAulaC_ExercicioHerançapolimorfismo3.Entities
{
    internal class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double anualincome, double healthexpeditures) : base(name, anualincome)
        {
            HealthExpenditures = healthexpeditures;
        }

        public override double TaxesCalculated()
        {
            if (AnualIncome > 20000)//anual menor que 20000
            {
                double calculation;
                if (HealthExpenditures > 0)//se gastou com saude
                {
                    calculation = AnualIncome + (AnualIncome * 0.075);
                }
                else if (AnualIncome > 20000)
                {
                    calculation = AnualIncome + (AnualIncome * 0.15);
                }
            }
        }
    }
}
