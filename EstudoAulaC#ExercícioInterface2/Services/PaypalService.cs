using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoAulaC_ExercícioInterface2.Services
{
    internal class PaypalService : IOnlinePaymentService 
    {

        private const double FeePercentage = 0.02; //define os valores da porcentagem do serviço,está como privada e const porque não precisa ser trocada
        private const double MonthlyInteres = 0.01;//define os valores da porcentagem de Juros Mensal,está como privada e const porque não precisa ser trocada

        public double Interest(double amount,int months)
        {
            return amount * MonthlyInteres * months;
        }
        public double PaymentFee(double amount) {
            return amount * FeePercentage; 
        }

    }
}
