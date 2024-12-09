using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoAulaC_ExercicioHerançaPolimorfismo2.Entities
{
    internal class UsedProduct : Product
    {
        public DateTime Date { get; set; }
        public UsedProduct() { }
        public UsedProduct(string Name, double Price, DateTime date) : base(Name, Price)
        {
            Date = date;
        }
        public override string priceTag()
        {
            return $"{Name} (used) $ {Price}  (Manufacture date:{Date.ToString("d")}  )";
        }
    }

}
