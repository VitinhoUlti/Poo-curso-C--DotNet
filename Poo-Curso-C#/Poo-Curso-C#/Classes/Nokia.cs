using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_Curso_C_.Classes
{
    internal class Nokia : Celular
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }
        public override void InstalarApp(string nome)
        {
            Console.WriteLine($"App {nome} instalado no Nokia");
        }
    }
}
