﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoAulaC_167.Entities
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }
        public override string ToString()
        {
            return Name + ", " + Price.ToString("F2");
        }
    }
}
