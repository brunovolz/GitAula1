using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliClass;

namespace UsandoBitlech
{
    class Program
    {
        static void Main(string[] args)
        {
            new bitlech().MetodoInicial();

            new bitlech().MetodoNovoEstaChegando(true);

            new bitlech().MetodoNovoEstaChegando(false);

            //Operação pesada como leitura e gravação na memoria
            var realizarTeste = new bitlech().TesteUmOperadorLegal();
            //Contagem de todos os registros da nossa lista
            var tamanhoLista = realizarTeste.Length;
            //Nosso for agora esta mais rapido
            for (int i = 0; i < tamanhoLista; i++)
            {
                Console.WriteLine(realizarTeste[i]);
            }

            Console.ReadKey();
        }
    }
}
