﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_Curso_C_.Classes
{
    internal abstract class Celular
    {
        public string Numero { get; set; }
        protected string Modelo { get; set; }
        protected string IMEI { get; set; }
        protected int Memoria { get; set; }
        public Celular(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }
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
