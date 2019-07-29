using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCsharp.Classe
{
    public class Conta
    {
        double saldo = 0;
        //Propriedade que contem o valor do saldo
        public double Saldo { get { return saldo; } }

        public Conta()
        {
            //Bonus de mil reais para operar na bolsa
            saldo = 1000;
        }
        /// <summary>
        /// Metodo para sacar dinheiro de acordo com saldo disponivel
        /// </summary>
        /// <param name="valor">Valor para sacar</param>
        /// <returns>retorna se o saque foi feito ou nao</returns>
        public bool Sacar(double valor)
        {
            if (valor <= saldo)
            { //Desconta do valor em saldo na conta
                saldo -= valor;
                return true;
            }
            //retorna false em caso de não conter saldo disponivel
            return false;

        }
        /// <summary>
        /// Metodo para mostrar o saldo em conta disponivel
        /// </summary>
        public double MostrarSaldo()
        {
            return saldo;
        }
    }
}
