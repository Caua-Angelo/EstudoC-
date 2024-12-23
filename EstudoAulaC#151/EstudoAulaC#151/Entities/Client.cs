using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoAulaC_151.Entities
{
    internal class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public override bool Equals(object obj)//verifica se dois objetos são iguais baseados no email
        {
           if (!(obj is Client))
            {
                return false;
            }
           Client other = obj as Client;
            return Email.Equals(other.Email);
        }

        public override int GetHashCode()
        {
            return Email.GetHashCode();//define que o critério de igualdade é o email
        }


    }
}
