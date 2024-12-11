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

        double FinalTaxes;
        public override double TaxesCalculated()
        {
            if (AnualIncome < 20000)//se a renda anual for menor que 20000.00
            {
                FinalTaxes = AnualIncome * 0.15;
            }
            else if (AnualIncome > 20000)//se a renda anual for maior que 20000.00
            {
                FinalTaxes = AnualIncome * 0.25;
            }
            if (HealthExpenditures > 0)
            {
                FinalTaxes = FinalTaxes - (HealthExpenditures / 2);
            }
            return FinalTaxes;
        }
    }
}

