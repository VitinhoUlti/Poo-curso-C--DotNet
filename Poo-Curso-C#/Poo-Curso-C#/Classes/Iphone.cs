using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_Curso_C_.Classes
{
    internal class Iphone : Celular
    {
        public override void InstalarApp(string nome)
        {
            Console.WriteLine($"App {nome} instalado no Iphone"); ;
        }
    }
}
