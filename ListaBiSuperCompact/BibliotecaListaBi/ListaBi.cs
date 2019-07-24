using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaBiSuperCompact.BibliotecaListaBi
{
    class ListaBi
    {
        string[,] listaBi;
        /// <summary>
        /// Iniciamos nossa lista bi, agora quando iniciamos uma instancia
        /// ela ja vem com a lista carregada.
        /// </summary>
        public ListaBi()
        {
            listaBi = new string[5, 2];
            //Ao chamar  este metodo no contrutor nossa lista ja vai estar carregada
            //ao iniciar a instancia "jogar para memoria"1
            CarregaListaBi();
        }
        /// <summary>
        /// Aqui carregamos "Popular" a lista quando chamamos este metodo.
        /// </summary>
        public void CarregaListaBi()
        {
            for (int i = 0; i < listaBi.GetLength(0); i++)
            {
                listaBi[i, 0] = i.ToString();
                listaBi[i, 1] = $"Felipe_{i}";
                //Ao adicionar o registro na lista ja mostramos na tela 
                Console.WriteLine($"Id:{i} Nome:Felipe_{i}");
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="idPesquisa"></param>
        public void PesquisaLista(string idPesquisa)
        {
            for (int i = 0; i < listaBi.GetLength(0); i++)
            {
                if (listaBi[i, 0] == idPesquisa)
                {
                    Console.WriteLine("Resultado encontrado!");
                    Console.WriteLine($"Voce pesquisou por: {listaBi[i, 1]}");

                    return;
                }
            }
        }
    }
}
