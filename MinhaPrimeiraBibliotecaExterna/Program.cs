using BibliotecaDeArquivosDoWindows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaPrimeiraBibliotecaExterna
{
    class Program
    {
        static void Main(string[] args)
        {
            var Files = new GetFiles();
            var Listas = Files.RetornaArquivosDoMeuDocumentos();

            for (int i = 0; i < Listas.Length; i++)
            {
                Console.WriteLine(Listas[i]);
            }
            Console.ReadKey();
            ///////////////////////////////////////////////////////
            Files.RetornaArquivosImagesFiles();
            var ListasImagens = Files.RetornaArquivosImagesFiles();

            for (int i = 0; i < ListasImagens.Length; i++)
            {
                Console.WriteLine(ListasImagens[i]);
            }
            Console.ReadKey();
            /////////////////////////////////////////////////////////
            Files.RetornaArquivosGit();
            var ListasGit = Files.RetornaArquivosGit();

            for (int i = 0; i < ListasGit.Length; i++)
            {
                Console.WriteLine(ListasGit[i]);
            }

            Console.ReadKey();

        }
    }
}
