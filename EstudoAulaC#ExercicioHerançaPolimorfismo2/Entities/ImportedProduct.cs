using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoAulaC_ExercicioHerançaPolimorfismo2.Entities
{
    internal class ImportedProduct : Product
    {
        public double Customfee { get; set; }
        public ImportedProduct() { }
        public ImportedProduct(string Name, double Price, double customfee) : base(Name, Price)
        {
            Customfee = customfee;
        }
        public double totalPrice()
        {
            return Price + Customfee;
        }
        public override string priceTag()
        {
            return $"{Name} $ {totalPrice()} (Customs fee: $ {Customfee:f2})";
           
        }

    }
}
