using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoAulaExerciciointerfaces.Entities
{
    internal class Rental
    {
        public string CarModel { get; set; }
        public DateTime Pickup { get; set; }
        public DateTime Return_ { get; set; }
        public double ValuePerHour { get; set; }
        public double ValuePerDay { get; set; }
        public Rental() { }
        public Rental(string carmodel, DateTime pickup, DateTime Return, double valueperhour, double valueperday)
        {
            CarModel = carmodel;
            Pickup = pickup;
            Return_ = Return;
            ValuePerHour = valueperhour;
            ValuePerDay = valueperday;
        }
        TimeSpan duracao;
        public void Duracao()
        {
            duracao = (Pickup - Return_);
        }
        double PagamentoTotal = 0;
        double ValorFinal(double valor)
        {
            if (duracao.Minutes >= 1)

                return 
        }
        public override string ToString()
        {
            return;
        }

        //SE O VALOR PASSAR DE 12 HORAS A LOCAÇÃO É COBRADO O VALOR DIARIO

        //DEPOIS DE CALCULADO O VALOR FINAL É CALCULADO O IMPOSTO SOBRE O VALOR DO ALUGUEL

        //- PARA VALORES ATÉ 100,00 | 20%
        //- PARA VALORES ACIMA DE 100,00 | 15%
    }
}
