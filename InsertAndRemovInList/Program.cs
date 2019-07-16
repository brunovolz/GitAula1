using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertAndRemovInList
{
    class Program
    {
        static void Main(string[] args)
        {
            //criamos a nossa base de dados
            string[,] baseDeDados = new string[2, 3];
            //Indicador dos registros realizados em nosso sistema
            int IndiceBaseDados = 0;
            Console.WriteLine("Iniciando sistema de listas com nome e idade.");
            //Criamos a variavel fora pra nao ser criada novamente
            var escolhaInicial = ApresentaçaoMenuInicial();
            //Loop infinito
            while (true)
            {   //Iniciando a escolha do nosso menu
                switch (escolhaInicial)
                {
                    //Inserir os metodos a serem executados.
                    case "1": { InserirValores(ref baseDeDados, ref IndiceBaseDados); } break;
                    case "2": { RemoverRegistro(ref baseDeDados); } break;
                    case "3": { MostrarInformaçoes(baseDeDados); } break;
                    case "4":
                        {
                            return;
                            //Return dentro do nosso caso de escolha ele sai do nosso metodo principal
                            //ou metodo que estamos dentro do contexto
                        }

                }
                //Alimento a escolha novamente.
                escolhaInicial = ApresentaçaoMenuInicial();
            }
        }
        /// <summary>
        /// Apresenta as informações do menu inicial.
        /// </summary>
        /// <returns>Retorna o menu escolhido.</returns>
        public static string ApresentaçaoMenuInicial()
        {
            Console.Clear();
            Console.WriteLine("========== MENU ===========");
            Console.WriteLine("1 - Inserir um novo registro");
            Console.WriteLine("2 - Remover um registro");
            Console.WriteLine("3 - Listar registros");
            Console.WriteLine("4 - Sair do sistema ");

            Console.WriteLine("Digite o número da opção desejada:");
            //retorna diretamente o menu escolhido.
            return Console.ReadLine();
        }
        /// <summary>
        /// Metodo que insere informações dentro da nossa base de dados
        /// </summary>
        /// <param name="baseDeDados">Base de dadosb como ref para alterar para todos os metodos</param>
        /// <param name="IndiceBaseDados">Indice da nossa base como ref para alterar para todos os metodos</param>
        public static void InserirValores(ref string[,] baseDeDados, ref int IndiceBaseDados)
        {
            Console.WriteLine("========== Inserindo valores na lista ===========\n");

            Console.WriteLine("Informe um nome:");
            //Esperamos o nome digitado pelo usuario para o sistema utilizar
            var nome = Console.ReadLine();
            //Esperamos a idade do usuario
            Console.WriteLine("Informe a idade");
            var idade = Console.ReadLine();
            //Iniciamos o laço de repetição para varrer nossa base de dados
            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                if (baseDeDados[i, 0] != null)
                    continue;
                //Identificamos de maneira unica nosso registro "("e")" garante que ele incremente
                //primeiro antes de fazer a conversão para string
                baseDeDados[i, 0] = (IndiceBaseDados++).ToString();
                //Carrega na segunda coluna o valor nome
                baseDeDados[i, 1] = nome;
                //Carrega na terceira coluna o valor idade
                baseDeDados[i, 2] = idade;
                //Finalizamos aqui para inserir apenas um registro por vez
                break;
            }
            //Informamos para o usuario que finalizou o registro e agora o mesmo irá voltar para o menu Inicial.
            Console.WriteLine("Registro cadastrado com sucesso!");
            Console.WriteLine("Para voltar ao menu Inicial, basta apertar qualquer tecla.");
            Console.ReadKey();
        }
        /// <summary>
        /// Mostra as informaçoes dentro da nossa lista de dados "basededados".
        /// </summary>
        /// <param name="baseDeDados">bade de dados para a leitura e mostrar pro usuario</param>
        public static void MostrarInformaçoes(string[,] baseDeDados)
        {
            //Informamos em que tela o mesmo esta
            Console.WriteLine("Apresentação das informações dentro da base de dados.");
            //Laço simple aonde o mesmo mostra de maneira formatada as informações
            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                Console.WriteLine($"ID {baseDeDados[i, 0]} " +
                    $"- Nome: {baseDeDados[i, 1]}" +
                    $"- Idade: {baseDeDados[i, 2]}");

                //Finalizamos a operação e indicamos que não existe mais operações a serem realizadas no metodo.
                Console.WriteLine("Resultados apresentados com sucesso!");
                Console.WriteLine("Para voltar ao menu Inicial informar qualquer tecla");
                Console.ReadKey();
            }
        }
        /// <summary>
        /// Metodo utilizado para remover um registro pelo ID dentro do sistema
        /// </summary>
        /// <param name="baseDeDados">Base de dados em que ele irá remover o registro pelo ID</param>
        public static void RemoverRegistro(ref string[,] baseDeDados)
        {
            Console.WriteLine("Área de remoção de registro do sistema.");
            //Laço de repetição para mostrar informações 

            Console.WriteLine("Informe o ID do RemoverRegistro a ser removido:");
            var id = Console.ReadLine();

            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {   //Indicamos pro usuario informar o ID para remoção
                Console.WriteLine($"ID:{baseDeDados[i, 0]} " +
                    $"- Nome:{baseDeDados[i, 1]} " +
                    $"- Idade:{baseDeDados[i, 2]}");

            }
            //Outro laço agora para remover o registro caso ele exista
            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {    //Aqui comparamos os registros para validar ID
                //Colocamos um "&&" pois a comparação de um valor string com valor null pode gerar erro.
                if (baseDeDados[i, 0] != null && baseDeDados[i, 0] == id)
                {   //Nesta parte limpamos o registro da nossa base de dados.
                    baseDeDados[i, 0] = null;
                    baseDeDados[i, 1] = null;
                    baseDeDados[i, 2] = null;
                }
            }
            Console.WriteLine("Operação finalizada");
            Console.WriteLine("Para retornar ao menu Inicial aperte qualquer tecla");
            Console.ReadKey();
        }
        /// <summary>
        /// Aumenta o tamanho da lista de acordo com necessidade
        /// </summary>
        /// <param name="ListaDeNome"></param>
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
                ListaDeNome = new string[ListaDeNome.GetLength(0) + 5, 3];
                //Agora copiamos os registros da nossa lista antiga e passamos para a nossa lista
                for (int i = 0; i < listaCopia.GetLength(0); i++)
                {
                    //Copiamos a informação do identificador unico
                    ListaDeNome[i, 0] = listaCopia[i, 0];
                    //Copiamos a informação do nosso nome
                    ListaDeNome[i, 1] = listaCopia[i, 1];
                    ListaDeNome[i, 2] = listaCopia[i, 2];

                }
                //Indicamos que neste ponto a lista foi atualiza em seu tamanho.
                Console.WriteLine("O tamanho da lista foi atualizado.");
            }
        }
    }
}
