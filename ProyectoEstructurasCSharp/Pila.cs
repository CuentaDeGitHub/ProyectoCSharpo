using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEstructurasCSharp
{
    class Pila
    {
        private Nodo top;
        public Nodo Top
        {
            get { return top; }
            set { top = value; }
        }

        public int Count
        {
            get
            {
                int c = 0;
                Nodo t = top;
                while (t != null)
                {
                    c++;
                    t = t.Siguiente;
                }
                return c;
            }
        }
        public Pila()
        {
            top = null;
        }

        public void Push(Nodo n)
        {
            n.Siguiente = top;
            top = n;
        }

        public Nodo Pop()
        {
            Nodo regreso = top;
            if (top != null)
            {
                top = top.Siguiente;
            }
            return regreso;
        }
        public override string ToString()
        {
            string stringPila = "";
            Nodo t = top;
            if (t != null)
            {
                stringPila += t.ToString();
                t = t.Siguiente;
                while (t != null)
                {
                    stringPila += "," + t.ToString();
                    t = t.Siguiente;
                }
                return stringPila;
            }
            else
            {
                return "La pila esta vacia";
            }
        }
    }
}
