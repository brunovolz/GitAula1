using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesEscola.Classes;

namespace BoletimEscolar
{
    public class Cadastro
    {
        string[,] arrayAluno = new string[5, 4];
        Boletim boletim = new Boletim();

        public void inserir()
        {
            for (int i = 0; i < arrayAluno.GetLength(0); i++)
            {
                Console.WriteLine("Informe o nome do aluno");
                var nome = Console.ReadLine();
                arrayAluno[i, 0] = nome;

                Console.WriteLine("Informe a nota 1");
                int.TryParse(Console.ReadLine(), out int nota1);

                Console.WriteLine("Informe a nota 2");
                int.TryParse(Console.ReadLine(), out int nota2);

                Console.WriteLine("Informe a nota 3");
                int.TryParse(Console.ReadLine(), out int nota3);
                
                //calculando a media
                var media = boletim.medias(nota1, nota2, nota3);
                arrayAluno[i, 1] = media.ToString();
                Console.WriteLine($"{media}");
                Console.Clear();
                //informações de frequencia
                Console.WriteLine("Informe o numero de aulas");
                int.TryParse(Console.ReadLine(), out int totalAulas);

                Console.WriteLine("Informe o numero de faltas");
                int.TryParse(Console.ReadLine(), out int numeroFaltas);
                var frequencia = boletim.frequencia(totalAulas, numeroFaltas);
                Console.Clear();
                //informa situação                
                arrayAluno[i, 3] = boletim.RetornaSituacao(media, frequencia);
            }
        }

        public void carregarLista(string[,] arrayAluno)
        {
            for (int i = 0; i < arrayAluno.GetLength(0); i++)
            {
                Console.WriteLine($"Nome:{arrayAluno[i, 0]}\n" +
                                  $"Média: {arrayAluno[i, 1]}");
            }
        }
    }

}
