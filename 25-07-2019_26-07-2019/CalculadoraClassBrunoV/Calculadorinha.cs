using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraClassBrunoV
{
    public class Calculadorinha
    {
        /// <summary>
        /// Calcula a soma de dois numeros em formato double, colocar por ex: (2,4)
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public double calculoSoma(double a, double b)
        {
            double soma = (a + b);
            return soma;
        }
        /// <summary>
        /// Calcula a subtração de dois numeros no mesmo formato da soma.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public double calculoSubtracao(double a, double b)
        {
            double subtracao = (a - b);
            return subtracao;
        }
        /// <summary>
        /// Multiplica dois números no mesmo formato anterior.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public double calculoMultiplicacao(double a, double b)
        {
            double multiplicacao = (a * b);
            return multiplicacao;
        }
        /// <summary>
        /// Divide dois numeros no mesmo formato anterior
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public double calculoDivisao(double a, double b)
        {
            double divisao = (a / b);
            return divisao;
        }
        /// <summary>
        /// Calcula a area de um triangulo
        /// </summary>
        /// <param name="pBase">base</param>
        /// <param name="pAltura">altura</param>
        /// <returns></returns>
        public double calculoTriangulo(double pBase, double pAltura)
        {
            double triangulo = ((pBase * pAltura) / 2);
            return triangulo;
        }
        /// <summary>
        /// Calcula area de um retangulo.
        /// </summary>
        /// <param name="pBase">base</param>
        /// <param name="pAltura">altura</param>
        /// <returns></returns>
        public double calculoRetangulo(double pBase, double pAltura)
        {
            double retangulo = (pBase * pAltura);
            return retangulo;
        }
        /// <summary>
        /// Calcula a area de um circulo em PI.
        /// </summary>
        /// <param name="pCircunferencia">Inserir a circunferencia do circulo </param>
        /// <returns></returns>
        public double calculoCirculo(double pCircunferencia)
        {
            return pCircunferencia / (2 * Math.PI);
        }
    }
}
