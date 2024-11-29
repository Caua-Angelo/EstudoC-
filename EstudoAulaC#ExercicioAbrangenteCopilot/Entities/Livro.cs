using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoAulaC_ExercicioAbrangenteCopilot.Entities
{
    internal class Livro
    {
        public String Titulo {  get; set; }
        public string Autor {  get; set; }
        public int AnoPublicacao { get; set; }
        public Livro() { }
        public Livro(string titulo,string autor,int anopublicacao)
        {
            Titulo = titulo;
            Autor = autor;
            AnoPublicacao = anopublicacao;
        }
        public override string ToString()
        {
            return "Titulo: " + Titulo + "," + "Autor: " + Autor + "," + "Ano De Publicação: " + AnoPublicacao;
        }
    }
}
