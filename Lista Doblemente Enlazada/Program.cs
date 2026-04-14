using Lista_Doblemente_Enlazada;
using System.Collections.Generic;
using System.Text;
using System;

namespace Lista_Doblemente_Enlazada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListaEnlazadaDoble lista = new ListaEnlazadaDoble();

            lista.AgregaIni(20);
            lista.AgregaIni(10);
            lista.AgregaFin(30);
            lista.AgregaFin(40);
            lista.Imprime();

            Console.WriteLine();
            Console.Write(lista.Length());

            Console.WriteLine();
            ListaEnlazadaDoble lista2 = new ListaEnlazadaDoble();

            lista2.AgregaFin(60);
            lista2.AgregaFin(70);
            lista2.AgregaFin(80);
            lista2.AgregaIni(50);
            lista2.Imprime();

            Console.WriteLine();
            lista.MezclarFin(lista2);
            lista.Imprime();
        }
    }
}
