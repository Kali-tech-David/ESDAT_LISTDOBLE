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
            
            while(actual != null)
            {
                cont++;
                actual = actual.Siguiente;
            }

            return cont;
        }

        public int Get(int idx)
        {
            int Count = Length();
            if(idx < 0 || idx >= Count)
            {
                return int.MinValue;
            }
            Nodo actual;

            if(idx < Count / 2)
            {
                actual = primero;
                for(int i = 0; i < idx; i++)
                {
                    actual = actual.Siguiente;
                }
            }
            else
            {
                actual = ultimo;
                for(int i = Count - 1; i > idx; i--)
                {
                    actual = actual.Anterior;
                }
            }
            return actual.Dato;
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

        public bool Buscar(int valor)
        {
            Nodo actual = ultimo;
            while(actual != null)
            {
                if(actual.Dato == valor)
                {
                    return true;
                }
                actual = actual.Anterior;
            }
            return false;
        }
    }
}
