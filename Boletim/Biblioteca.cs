using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesEscola.Classes
{
    public class Boletim
    {

        public static string[,] NomeAlunos;

        public int medias(int nota1, int nota2, int nota3)
        {
            return (nota1 + nota2 + nota3) / 3;
        }

        public int frequencia(int totalAulas, int numeroFaltas)
        {
            return ((totalAulas - numeroFaltas) * 100) / totalAulas;
        }

        public void situacao(int media, int frequencia)
        {
            if ((media >= 7) && (frequencia >= 75))
            {
                Console.WriteLine($"Aluno aprovado com média {media} e frequencia de {frequencia}%");
            }
            else
            {
                Console.WriteLine($"Aluno reprovado com média {media} e frequencia de {frequencia}%");
            }
        }

        public void baseAlunos(string media, string frequencia,string situacao)
        {
            NomeAlunos = new string[5, 4]
            {
                {"Jõao",$"{media}",$"{frequencia}",$"{situacao}"},
                {$"Mário",$"{media}",$"{frequencia}",$"{situacao}"},
                {$"José",$"{media}",$"{frequencia}",$"{situacao}"},
                {$"Carlos",$"{media}",$"{frequencia}",$"{situacao}"},
                {$"Josefina",$"{media}",$"{frequencia}",$"{situacao}"}
            };
        }
        public void listarAlunos()
        {
            Console.WriteLine("Listagem de alunos:");

            for (int i = 0; i < NomeAlunos.GetLength(0); i++)
            {
                Console.WriteLine($"Nome: {NomeAlunos[i, 0]}\n Média:{NomeAlunos[i, 1]}\n" +
                    $"Frquencia: {NomeAlunos[i, 2]}\n Situação: {NomeAlunos[i, 3]}");
            }
            return;
        }
    }
}