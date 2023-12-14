// See https://aka.ms/new-console-template for more information

using Poo_Curso_C_.Classes;

//Crianção das instancias
Nokia n1 = new Nokia()
{
    Numero = "Io5"
};
Iphone i1 = new Iphone()
{
    Numero = "M25"
};

//Você pode explorar os metodos dos celulares
n1.InstalarApp("Jogo da Cobrinha");
i1.Ligar();