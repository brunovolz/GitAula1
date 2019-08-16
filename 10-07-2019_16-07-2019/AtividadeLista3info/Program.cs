using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeLista3info
{
    class Program
    {//ID, USUARIO, IDADE
        static void Main(string[] args)
        {
            string[,] listaUsuario = new string[2, 3];

            int IDlista = 0;

            InsereRegistro(ref listaUsuario, ref IDlista);

            Console.ReadKey();

            InsereRegistro(ref listaUsuario, ref IDlista);

            Console.ReadKey();

            ServidorNasa();
        }
        public static void InsereRegistro(ref string[,] listaUsuario, ref int IDlista)
        {
            for (int i = 0; i < listaUsuario.GetLength(0); i++)
            {
                if(listaUsuario[i, 0] != null)
                    continue;

                Console.WriteLine("\nInforme seu Nome:");
                var nome = Console.ReadLine();

                Console.WriteLine("\nInforme seu Idade para te registrarmos no sistema");
                var idade = Console.ReadLine();

                listaUsuario[i, 0] = (IDlista++).ToString();
                listaUsuario[i, 1] = nome;
                listaUsuario[i, 2] = idade;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\r\nCadatrado com sucesso!\n");
                Console.ResetColor();
                Console.WriteLine("\nDeseja inserir um novo registro? Sim (1) ou Não (0)");
                var continuar = Console.ReadKey().KeyChar.ToString();

                if (continuar == "0")
                    break;

                AumentarTamanhoLista(ref listaUsuario);
            }
            for (int i = 0; i < listaUsuario.GetLength(0); i++)
            {
                Console.WriteLine(string.Format("Registro ID {0} - Nome:{1} - Idade: {2}", listaUsuario[i, 0], listaUsuario[i, 1], listaUsuario[i, 2]));
            }
        }
        public static void AumentarTamanhoLista(ref string[,] listaUsuario)
        {
            var LimiteLista = true;

            for (int i = 0; i < listaUsuario.GetLength(0); i++)
            {
                //Caso ainda existir registro disponivel ele seta nossa variavel "LimiteLista" para false.
                if (listaUsuario[i, 0] == null)
                    LimiteLista = false;
            }
            if (LimiteLista)
            {
                var listaCopia = listaUsuario;

                listaUsuario = new string[listaUsuario.GetLength(0) + 2, 3];

                for (int i = 0; i < listaCopia.GetLength(0); i++)
                {
                    listaUsuario[i, 0] = listaCopia[i, 0];
                    listaUsuario[i, 1] = listaCopia[i, 1];
                    listaUsuario[i, 2] = listaCopia[i, 2];              
                }
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\nO tamanho da lista foi atualizado.");
                Console.ResetColor();
            }
        }
        public static void ServidorNasa()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("==============================");
            Console.WriteLine("BEM VINDO AO SERIDOR DA NASA  ");
            Console.WriteLine("==============================");
            Console.WriteLine("IP ADDRES:  128.154.26.11");
            Console.WriteLine("==============================");
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("                HELLO WORD!                 ");
            Console.ReadKey();
        }

    }
}
