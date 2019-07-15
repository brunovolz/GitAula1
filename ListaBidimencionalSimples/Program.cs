using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaBidimencionalSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando nossa lista com mais de uma dimensão.
            string[,] listaDeNomes = new string[5, 2];

            //Aqui como estamos usando apenas uma referencia da nossa lista colocamos ref
            //ao passar ela no metodo.
            CarregarInformaçoes(ref listaDeNomes);
        }
        /// <summary>
        /// Metodo que carrega as informações dentro da nossa lista criada no metodo "MAIN"
        /// E mostra as informações logo em seguida.
        /// </summary>
        /// <param name="arrayBi">Nossa lista a ser carregada</param>
        public static void CarregarInformaçoes(ref string[,] arrayBi)
        {
            //Usando um laço simples para colocar valores agora utilizando o 
            //GetLength com o paramentro "0" indicar que queremos o tamanho da primeira coluna
            for (int i = 0; i < arrayBi.GetLength(0); i++)
            {
                //Carregando o que podemos chamar de ID, identificador do nosso registro unico
                arrayBi[0, 0] = i.ToString();
                //Aqui apenas idicionamos uma informação extra
                arrayBi[i, 1] = $"Bruno{i}";
            }

            //Lembrando que GetLenght é um metodo e usamos "(parametro)" com parametro ou as vezes,
            //sem para realizar a chamada do mesmo.
            for (int i = 0; i < arrayBi.GetLength(0); i++)
            {
                //formamos uma string de maneira que os dados sejam apresentados.
                Console.WriteLine($"ID:{arrayBi[i, 0]} - Nome:{arrayBi[i, 1]}");
            }
            Console.ReadKey();
        }
        /// <summary>
        /// Metodo que realiza a pesquisa pelo identificador unico da nossa coleção
        /// </summary>
        /// <param name="arrayBi">Nosa coleção de informações.</param>
        /// <param name="pId">Nosso identifciador unico.</param>
        public static void PesquisandoInformaçoes(ref string[,] arrayBi, string pId)
        {
            for (int i = 0; i < arrayBi.GetLength(0); i++)
            {//Realizamos nossa comparação dos mesmos tipos
                if (arrayBi[i, 0] == pId)
                {    //Mostramos as informações formatadas da nossa pesquisa
                    Console.WriteLine($"Informação escolhida: Id:{arrayBi[i, 0]} - Nome: {arrayBi[i, 1]}");
                    //Aqui saimos da nossa lista mas retornamos vazio "return;" pois estamos em um metodo
                    //vazio "void" que nao espera retornar algo.

                    return;
                }
            }

            //Caso ele passe por esta linha identificamos que nao encontrou resultados compativeis.
            Console.WriteLine("Infelizmente a busca pelo id nao resultou em nenhuma informação");
        }
    }
}
