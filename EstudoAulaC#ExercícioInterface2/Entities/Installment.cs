using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoAulaC_ExercícioInterface2.Entities
{
    internal class Installment
    {
        public DateTime DueDate { get; set; }
        public double Amount { get; set; }

        public Installment()
        {
        }
        public Installment(DateTime date, double amount)
        {
            DueDate = date;
            Amount = amount;
        }
        public override string ToString()
        {
            return DueDate.ToString("dd/MM/yyyy")
               + " - "
               + Amount;
        }
    }
}
