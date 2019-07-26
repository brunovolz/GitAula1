using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliClass
{
    public class bitlech
    {   /// <summary>
        /// inicio
        /// </summary>
        public void MetodoInicial()
        {
            Console.WriteLine("Iniciando o sisteminha!");

            Console.ReadKey();
        }
        /// <summary>
        /// Metodo booleano para retornar true ou false
        /// </summary>
        /// <param name="eQuinta">2.0</param>
        public void MetodoNovoEstaChegando(bool eQuinta)
        {
            if (eQuinta)
                Console.WriteLine("caraca boludo");
            else
                Console.WriteLine("aiaiaiai");

            Console.ReadKey();
        }
        /// <summary>
        /// Metodo que vamos identificar o tipo
        /// </summary>
        /// <returns>retorna algo?</returns>
        public string[] TesteUmOperadorLegal()
        {
            return new string[2]{"Teste 1 ","Teste 2" };
        }
    }
}
