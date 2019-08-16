using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaBiSimplesComClass.Carrega
{
    class CarregarLista
    {
        string[,] listaDeNomes;

        /// <summary>
        /// Nosso metodo contrutor sempre recebe o nome da classe
        /// </summary>
        /// <param name="arrayBi">Array q ja deve estar assinada</param>
        public CarregarLista()
        {
            listaDeNomes = new string[5, 2];
        }

        /// <summary>
        /// Metodo que carrega as informações dentro da nossa lista criada no metodo "MAIN"
        /// E mostra as informações logo em seguida.
        /// </summary>
        /// <param name="arrayBi">Nossa lista a ser carregada</param>
        public void CarregarInformaçoes()
        {
            //Usando um laço simples para colocar valores agora utilizando o 
            //GetLength com o paramentro "0" indicar que queremos o tamanho da primeira coluna
            for (int i = 0; i < listaDeNomes.GetLength(0); i++)
            {
                //Carregando o que podemos chamar de ID, identificador do nosso registro unico
                listaDeNomes[i, 0] = i.ToString();
                //Aqui apenas idicionamos uma informação extra
                listaDeNomes[i, 1] = $"Bruno{i}";
            }

            //Lembrando que GetLenght é um metodo e usamos "(parametro)" com parametro ou as vezes,
            //sem para realizar a chamada do mesmo.
            for (int i = 0; i < listaDeNomes.GetLength(0); i++)
            {
                //formamos uma string de maneira que os dados sejam apresentados.
                Console.WriteLine($"ID:{listaDeNomes[i, 0]} - Nome:{listaDeNomes[i, 1]}");
            }
            Console.ReadKey();
        }
    }
}
