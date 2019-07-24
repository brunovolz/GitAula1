using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriandoListas.NewFolder1
{
    class Class1
    {
        string[] Lista;

        public Class1()
        {
            Lista = new string[10];
        }
        public void CarregaLista()
        {
            for (int i = 0; i < Lista.GetLength(0); i++)
            {
                Lista[i] = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss:fff");
            }
            foreach (var item in Lista)
                Console.WriteLine(item);

            Console.ReadKey();
        }
        public void LimpaLista()
        {
            for (int i = 0; i < Lista.Length; i++)
            {
                Lista[i] = string.Empty;
            }
            foreach (var item in Lista)
                Console.WriteLine(item);

            Console.ReadKey();
        }
    }
}

        