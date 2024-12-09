using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace EstudoAulaC_ExercicioHerançaPolimorfismo2.Entities
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Product() { }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public virtual string priceTag()
        {
            //return  Name + " $ " + Price;
            return $"{Name} $ {Price:f2} ";
            //return ("{0}$ {1:f2}", Name, Price);
        }
    }
}