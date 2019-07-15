using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Manualmente
namespace AdicionandoValoresEmUmaLista
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criação da nossa lista
            string[,] listaDeNomes = new string[10, 2];
            //Aqui vamos criar uma forma externa de identificar nossos registros
            int IdParaLista = 0;

            //Aqui estaremos em um laço para informar nosso registros
            for (int i = 0; i < listaDeNomes.GetLength(0); i++)
            {
                Console.WriteLine("Informe um nome para adicionar um registro:");
                var nome = Console.ReadLine();
                //Criamos nosso identificador unico com um objetivo externo que
                //mesmo após sairmos do nosso laço ainda podera ser incrementado
                listaDeNomes[i, 0] = (IdParaLista++).ToString();
                //Aqui colocamos nosso nome na lista
                listaDeNomes[i, 1] = nome;

                Console.WriteLine("Deseja inserir um novo registro? Sim (1) ou Não (2)");
                //O .ReadKey só espera um unica tecla e nos retorna a tecla que foi acionada,
                //e não o valor dela. Por isso usamos o .KeyChar para pegar esse valor e converter
                //ele em uma string para comparação
                var continuar = Console.ReadKey().KeyChar.ToString();
                //Aqui validamos a condição se o mesmo deve ou não continuar a adicionar registro
                //até que nossa lista esteja completa de informações
                if (continuar == "0")
                    break; //Break é uma palavra reservada do c# que para PARA todo o laço de repetição ou sequenciador logico.
            }

            Console.WriteLine("Registro adicionado com sucesso, segue lista de informações adicionadas:");

            //Mas agora a coisa muda,
            for (int i = 0; i < listaDeNomes.GetLength(0); i++)
            {//Utilizamos o string format, basicamente ele faz da mesma forma que o sifrão
                //a diferença entre eles é que este é um cara em grandes quantidades
                //e acaba sendo mais rapido
                Console.WriteLine(string.Format("Registro ID {0} - Nome:{0}", listaDeNomes[i,0], listaDeNomes[i,1]));
            }
            Console.ReadKey();
        }
    }
}
