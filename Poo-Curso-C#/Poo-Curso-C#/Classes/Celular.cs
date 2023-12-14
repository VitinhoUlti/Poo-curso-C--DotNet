using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_Curso_C_.Classes
{
    internal abstract class Celular
    {
        public string Numero;
        protected string Modelo;
        protected string IMEI;
        protected int Memoria;
        public void Ligar()
        {
            Console.WriteLine("Ligou");
        }
        public void ReceberLigação()
        {
            Console.WriteLine("Estão Ligando Para Você");
        }
        public abstract void InstalarApp(string nome);
    }
}
