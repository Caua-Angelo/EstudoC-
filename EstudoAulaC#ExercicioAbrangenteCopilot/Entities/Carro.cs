using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoAulaC_ExercicioAbrangenteCopilot.Entities
{
    internal class Carro
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public int Ano { get; set; }

        public Carro() { }

        public Carro(string marca, string modelo, string cor, int ano)
        {
            Marca = marca;
            Modelo = modelo;
            Cor = cor;
            Ano = ano;
        }
        public override string ToString()
        {
            return "Marca: " + Marca + "," + "Modelo: " + Modelo + "," + "Cor: " + Cor + "," + "Ano: " + Ano;
        }
    }
}
