using System;
using System.Collections.Generic;
using System.Text;

namespace Lista_Doblemente_Enlazada
{
    internal class Nodo
    {
        private int dato;
        private Nodo siguiente;
        private Nodo anterior;

        public Nodo(int dato)
        {
            this.Dato = dato;
            this.Siguiente = null;
            this.Anterior = null;
        }

        public int Dato { get => dato; set => dato = value; }
        internal Nodo Siguiente { get => siguiente; set => siguiente = value; }
        internal Nodo Anterior { get => anterior; set => anterior = value; }
    }
}
