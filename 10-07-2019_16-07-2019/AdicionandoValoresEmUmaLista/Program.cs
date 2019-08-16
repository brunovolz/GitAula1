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
            //Chama no nosso metodo para inserir registro passando por meio da referencia
            //nossos dois itens, lista de nomes e nosso identificador unico
            InsereRegistro(ref listaDeNomes, ref IdParaLista);

            Console.ReadKey();

            InsereRegistro(ref listaDeNomes, ref IdParaLista);
            //Aqui acionamos novamenteo nosso inserir registros
            Console.ReadKey();
        }
        /// <summary>
        /// Metodo que insere novo registro dentro da nossa lista
        /// </summary>
        /// <param name="listaDeNomes">Nossa lista de nomes vazia ou não</param>
        /// <param name="IdParaLista"></param>
        public static void InsereRegistro(ref string[,] listaDeNomes, ref int IdParaLista)
        {
            //Aqui estaremos em um laço para informar nosso registros
            for (int i = 0; i < listaDeNomes.GetLength(0); i++)
            {
                //Aqui definimos que o mesmo deve continuar para o próximo registro
                //pois esse registro ja esta ocupado
                if (listaDeNomes[i, 0] != null)
                    continue;

                Console.WriteLine("\r\nInforme um nome para adicionar um registro:");
                var nome = Console.ReadLine();
                //Criamos nosso identificador unico com um objetivo externo que
                //mesmo após sairmos do nosso laço ainda podera ser incrementado
                listaDeNomes[i, 0] = (IdParaLista++).ToString();
                //Aqui colocamos nosso nome na lista
                listaDeNomes[i, 1] = nome;

                Console.WriteLine("Deseja inserir um novo registro? Sim (1) ou Não (0)");
                //O .ReadKey só espera um unica tecla e nos retorna a tecla que foi acionada,
                //e não o valor dela. Por isso usamos o .KeyChar para pegar esse valor e converter
                //ele em uma string para comparação
                var continuar = Console.ReadKey().KeyChar.ToString();
                //Aqui validamos a condição se o mesmo deve ou não continuar a adicionar registro
                //até que nossa lista esteja completa de informações
                if (continuar == "0")
                    break; //Break é uma palavra reservada do c# que para PARA todo o laço de repetição ou sequenciador logico.

                AumentarTamanhoLista(ref listaDeNomes);
            }

            Console.WriteLine("Registro adicionado com sucesso, segue lista de informações adicionadas:");

            //Mas agora a coisa muda,
            for (int i = 0; i < listaDeNomes.GetLength(0); i++)
            {//Utilizamos o string format, basicamente ele faz da mesma forma que o sifrão
                //a diferença entre eles é que este é um cara em grandes quantidades
                //e acaba sendo mais rapido
                Console.WriteLine(string.Format("Registro ID {0} - Nome:{1}", listaDeNomes[i, 0], listaDeNomes[i, 1]));
            }
        }
        public static void AumentarTamanhoLista(ref string[,] ListaDeNome)
        {
            //Verifica se precisa criar uma lista maior
            var LimiteLista = true;
            //Laço que verifica se existe registro disponivel
            for (int i = 0; i < ListaDeNome.GetLength(0); i++)
            {
                //Caso ainda existir registro disponivel ele seta nossa variavel "LimiteLista" para false.
                if (ListaDeNome[i, 0] == null)
                    LimiteLista = false;
            }
            //Caso nao tenha mais registro nossa variavel ficou como true então indica que precisamos aumentar nossa lista
            if (LimiteLista)
            {
                //criamos uma cópia da nossa lista para não perder os valores
                var listaCopia = ListaDeNome;
                //Aqui limpamos nossa lista antiga e assinamos novamente com uma lista com mais espaços
                ListaDeNome = new string[ListaDeNome.GetLength(0) + 5, 2];
                //Agora copiamos os registros da nossa lista antiga e passamos para a nossa lista
                for (int i = 0; i < listaCopia.GetLength(0); i++)
                {
                    //Copiamos a informação do identificador unico
                    ListaDeNome[i, 0] = listaCopia[i, 0];
                    //Copiamos a informação do nosso nome
                    ListaDeNome[i, 1] = listaCopia[i, 1];

                }
                //Indicamos que neste ponto a lista foi atualiza em seu tamanho.
                Console.WriteLine("O tamanho da lista foi atualizado.");
            }
        }
    }
}
