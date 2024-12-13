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
        public String CarModel { get; set; }
        public DateTime Pickup { get; set; }
        public DateTime Return_ { get; set; }
        public Double ValuePerHour { get; set; }
        public Double ValuePerDay { get; set; }
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
        Double basicpayment;
        Double tax;
        Double paymentFinal;
        public void Duracao()
        {
            duracao = Return_ - Pickup;
        }
        public void Finalpayment()
        {
            Duracao();
            if (duracao.Hours > 12)//se a quantidade de horas for maior que 12
            {
                if (duracao.Minutes >= 1)
                {
                    basicpayment = (ValuePerDay + 1) * duracao.Days;
                }
                else if(duracao >)
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
            if (basicpayment <= 100)
            {
                tax = (basicpayment * 0.20);
            }
            else
            {
                tax = (basicpayment * 0.15);
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
