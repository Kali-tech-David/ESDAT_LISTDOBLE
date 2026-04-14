using System;
using System.Collections.Generic;
using System.Text;

namespace Lista_Doblemente_Enlazada
{
    internal class ListaEnlazadaDoble
    {
        private Nodo primero;
        private Nodo ultimo;
        
        public ListaEnlazadaDoble()
        {
            primero = null;
            ultimo = null;
        }
        public void AgregaIni(int valor)
        {
            Nodo nuevo = new Nodo(valor);

            if (primero == null)
            {
                primero = nuevo;
                ultimo = nuevo;
            }
            else
            {
                nuevo.Siguiente = primero;
                primero.Anterior = nuevo;
                primero = nuevo;
            }
        }

        public void AgregaFin(int valor)
        {
            Nodo nuevo = new Nodo(valor);

            if (primero == null)
            {
                primero = nuevo;
                ultimo = nuevo;
            }
            else
            {
                nuevo.Anterior = ultimo;   
                ultimo.Siguiente = nuevo; 
                ultimo = nuevo;           
            }
        
        }

        public void Imprime()
        {
            if (primero == null)
            {
                Console.WriteLine("Lista vacía");
                return;
            }

            Nodo temp = primero;

            do
            {
                Console.WriteLine(temp.Dato);
                temp = temp.Siguiente;

            } while (temp != null);
        }

        public int Length()
        {
            int cont = 0;
            Nodo actual = primero;
            do
            {
                cont++;
                actual = actual.Siguiente;
            } while (actual != null);
            return cont;
        }

        public void MezclarFin(ListaEnlazadaDoble lista)
        {
            if (lista == null)
                return;
            else if (this.primero == null)
            {
                primero = lista.primero;
                ultimo = lista.ultimo;
            }
            else
            {
                lista.primero.Anterior = ultimo;
                ultimo.Siguiente = lista.primero;
                ultimo = lista.ultimo;
            } 
        }
    }
}
