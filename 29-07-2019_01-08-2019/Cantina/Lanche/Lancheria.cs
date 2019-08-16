using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantina.Lanche
{
    public class Lancheria
    {
        double saldo = 20;
        public Lancheria()
        {
            saldo = 20;
        }
        public bool ComprarLanche(string pLanche)
        {
            double Coxinha = 2;
            double Pastel = 3;
            if (pLanche == "coxinha" && Coxinha <= saldo)
            {
                saldo -= Coxinha;
                return true;
            }
            if (pLanche == "pastel" && Pastel <= saldo)
            {
                saldo -= Pastel;
                 return true;
            }
            return false;
        }
        public double MostrarSaldo()
        {
            return saldo;
        }
    }
}
