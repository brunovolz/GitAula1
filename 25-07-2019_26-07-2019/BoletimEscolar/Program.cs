using ClassesEscola.Classes;
using BoletimEscolar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorEscola
{
    class Program
    {
        static void Main(string[,] arrayAluno)
        {
            var insert = new Cadastro();
            insert.inserir();
            insert.carregarLista();
            Console.ReadKey();

        }
    }
}