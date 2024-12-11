using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoAulaC_ExercicioHerançapolimorfismo3.Entities
{
    internal class Company : TaxPayer
    {
        public int WorkersNumber { get; set; }
        public Company(string name, double anualincome, int workers) : base(name, anualincome)
        {
            WorkersNumber = workers;
        }
        double FinalTaxes;
        public override double TaxesCalculated()
        {
            if (WorkersNumber > 10)//se o numero de trabalhadores for maior que 10
            {
                FinalTaxes = AnualIncome * 0.14;
            }
            else//se não for
            {
                FinalTaxes = AnualIncome * 0.16;
            }
            return FinalTaxes;
        }
    }
}
