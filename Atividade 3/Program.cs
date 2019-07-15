using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_3
{
    class Program
    {
        static string[,] ListaDeAlunos;
        static void Main(string[] args)
        {
            CarregaListaAlunos();
            Console.WriteLine("============================================");
            Console.WriteLine("LISTA DE ALUNOS DO CURSO DE TEATRO DA ESCOLA");
            Console.WriteLine("============================================\n");
            Console.WriteLine("\nPressione qualquer tecla para ver a lista ");
            Console.ReadLine();

            for (int i = 0; i < ListaDeAlunos.GetLength(0); i++)
            {
                Console.WriteLine($" NOME: {ListaDeAlunos[i, 0]} |" +
                    $"| IDADE: {ListaDeAlunos[i, 1]} || SEXO: {ListaDeAlunos[i, 2]}");
            }
            Console.ReadKey();

        }
        /// <summary>
        /// Dados dos alunos.
        /// </summary>
        public static void CarregaListaAlunos()
        {
            ListaDeAlunos = new string[20, 3]
            {
             {"JÃO","18","MASCULINO"},
             {"MARCÃO","19","MASCULINO"},
             {"JORJÃO","20","MASCULINO"},
             {"SEBASTIÃO","28","MASCULINO"},
             {"SÃO SEBASTIÃO","34","MASCULINO"},
             {"ROBERTÃO","33","MASCULINO"},
             {"FELIPÃO","30","MASCULINO"},
             {"MORANGÃO","18","SEM GENERO DEFINIDO"},
             {"ROBERTINHA","18","FEMININO"},
             {"SONIAZINHA","19","FEMININO"},
             {"FERNANDINHA","20","FEMININO"},
             {"MARCINHA","24","FEMININO"},
             {"GRACINHA","25","FEMININO"},
             {"ROSA","97","FEMININO"},
             {"LURDINHA","80","FEMININO"},
             {"MOISES","50","MASCULINO"},
             {"SERAFINA","101","FEMININO"},
             {"NORBERTO","37","MASCULINO"},
             {"MARC","20","MASCULINO"},
             {"SIMARIA","60","FEMININO"}
            };
        }
    }
}
