using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace EstudoAulaExerciciointerfaces.Entities
{
    internal class Rental
    {
        public Double ValuePerHour { get; set; }
        public Double ValuePerDay { get; set; }
        public Rental() { }
        public Rental( double valueperhour, double valueperday)
        {
            ValuePerHour = valueperhour;
            ValuePerDay = valueperday;
        }
        TimeSpan duracao;
        Double basicpayment;
        Double tax;
        Double paymentFinal;
        
        public void Finalpayment()
        {
            if (duracao.Hours > 12)//se a quantidade de horas for maior que 12
            {
                if (duracao.Minutes >= 1)
                {
                    basicpayment = (ValuePerDay + 1) * duracao.Days;
                }
                else if(duracao.Hours > 0)
                {
                    basicpayment = ValuePerDay * duracao.Days;
                }
            }
            else if (duracao.Hours < 12)
            {
                if (duracao.Minutes >= 1)
                {
                    basicpayment = (duracao.Hours + 1) * ValuePerHour;
                }
            }
           
            paymentFinal = basicpayment + tax;
        }
        public override string ToString()
        {
            return "INVOICE: " + Environment.NewLine
                + "Basic payment: " + basicpayment + Environment.NewLine
                + "Tax: " + tax + Environment.NewLine
                + "Total: " + paymentFinal
                ;
        }
    }
}
