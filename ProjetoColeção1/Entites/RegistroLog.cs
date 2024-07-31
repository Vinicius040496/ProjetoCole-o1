using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoColeção1.Entites
{
    internal class RegistroLog
    {
        public string NomeUsuario { get; set; }
        public DateTime Momento { get; set; }

        public override int GetHashCode()
        {
            return NomeUsuario.GetHashCode();
        }

        public RegistroLog(string nomeUsuario, DateTime momento)
        {
            NomeUsuario = nomeUsuario;
            Momento = momento;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is RegistroLog)) { 
                return false;
            }
            else
            {
                RegistroLog other = (RegistroLog) obj;
                return NomeUsuario == other.NomeUsuario;
            }
            
        
        }
    }
}
