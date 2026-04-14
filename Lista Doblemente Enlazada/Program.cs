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

            Console.WriteLine("Agregando elementos a la lista:");
            lista.AgregaIni(20);
            lista.AgregaIni(10);
            lista.AgregaFin(30);
            lista.AgregaFin(40);
            lista.Imprime();
            Console.WriteLine();

            Console.WriteLine($"La lista mide: {lista.Length()}");
            Console.WriteLine();

            ListaEnlazadaDoble lista2 = new ListaEnlazadaDoble();
            Console.WriteLine("Agregando elementos a la segunda lista: ");
            lista2.AgregaFin(60);
            lista2.AgregaFin(70);
            lista2.AgregaFin(80);
            lista2.AgregaIni(50);
            lista2.Imprime();
            Console.WriteLine();

            Console.WriteLine("La primer lista mezclada con la segunda es: ");
            lista.MezclarFin(lista2);
            lista.Imprime();
            Console.WriteLine();


            Console.WriteLine($"El valor del primer elemento es: {lista.Get(0)}");
            Console.WriteLine();

            Console.WriteLine("Buscando el elemento 80: ");
            bool encontrado1 = lista.Buscar(80);
            if (encontrado1)
                Console.Write("El valor existe.");
            else
                Console.Write("El valor no existe.");
            Console.WriteLine();

            Console.WriteLine("Buscando el elemento 100:");
            bool encontrado2 = lista.Buscar(100);
            if (encontrado2)
                Console.Write("El valor existe.");
            else
                Console.Write("El valor no existe.");
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("Eliminando el valor 50.\nLa lista quedaría como:");
            lista.Eliminar(50);
            lista.Imprime();
            Console.WriteLine();
        }
    }
}
