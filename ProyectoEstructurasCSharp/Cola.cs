using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEstructurasCSharp
{
    class Cola
    {
        private Nodo head;
        public Nodo Head
        {
            get { return head; }
            set { head = value; }
        }
        private Nodo tail;

        public Nodo Tail
        {
            get { return head; }
            set { head = value; }
        }
        public Cola()
        {
            head = null;
            tail = null;
        }
        public void Encolar(Nodo n)
        {
            if (head == null)
            {
                head = n;
                tail = n;
            }
            else
            {
                tail.Siguiente = n;
                tail = n;
            }
        }
        public void Desencolar()
        {
            if (head == tail)
            {
                head = null;
                tail = null;
                return;
            }
            head = head.Siguiente;
        }
        public int Front()
        {
            return head.Dato;
        }
        public override string ToString()
        {
            string stringCola = "";
            Nodo h = head;
            if (h != null)
            {
                stringCola += h.ToString();
                h = h.Siguiente;
                while (h != null)
                {
                    stringCola += "," + h.ToString();
                    h = h.Siguiente;
                }
                return stringCola;
            }
            else
            {
                return "La cola esta vacia";
            }
        }
    }
}
