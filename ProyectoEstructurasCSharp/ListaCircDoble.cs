using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEstructurasCSharp
{
    class ListaCircDoble
    {
        private NodoDoble head;
        public NodoDoble Head
        {
            get { return head; }
            set { head = value; }
        }
        public ListaCircDoble()
        {
            head = null;
        }
        public ListaCircDoble(NodoDoble n)
        {
            head = n;
            n.Anterior = head;
            n.Siguiente = head;
        }

        public void Agregar(NodoDoble n)
        {
            NodoDoble h = head;
            if (head == null)
            {
                head = n;
                head.Anterior = head;
                head.Siguiente = head;
                return;
            }

            if (n.Dato < head.Dato)
            {
                head.Anterior.Siguiente = n;
                n.Anterior = head.Anterior;
                n.Siguiente = head;
                head.Anterior = n;
                head = n;
                return;
            }

            do
            {
                if (n.Dato < h.Siguiente.Dato)
                {
                    break;
                }
                h = h.Siguiente;
            } while (h != head);
            if (n.Dato < h.Siguiente.Dato)
            {
                h.Siguiente.Anterior = n;
                n.Anterior = h;
                n.Siguiente = h.Siguiente;
                h.Siguiente = n;
            }
            else
            {
                n.Siguiente = h;
                n.Anterior = h.Anterior;
                h.Anterior.Siguiente = n;
                h.Anterior = n;
            }
        }
        public bool Buscar(int b) //metodo para buscar un nodo
        {
            NodoDoble h = head;
            if (h != null)
            {
                do
                {
                    if (h.Dato == b)
                    {
                        return true;
                    }
                    h = h.Siguiente;
                } while (h != head);
            }
            return false;
        }

        public int ContarNodos()
        {
            int contador = 0;
            if (head != null)
            {
                NodoDoble h = head;
                do
                {
                    contador++;
                    h = h.Siguiente;
                } while (h != head);
            }
            return contador;
        }

        public void Eliminar(int b)
        {
                NodoDoble h = head;
                while (h.Siguiente != head)
                {
                    if (h.Dato == b)
                    {
                        break;
                    }
                    h = h.Siguiente;
                }
                h.Anterior.Siguiente = h.Siguiente;
                h.Siguiente.Anterior = h.Anterior;
                if (h == head)
                {
                    head = head.Siguiente;
                }          
        }

        public override string ToString()
        {
            string lista = "";
            NodoDoble h = head;
            if (h != null)
            {
                do
                {
                    lista += h.Dato + ", ";
                    h = h.Siguiente;
                } while (h != head);
                lista += ".";
                lista = lista.Replace(", .", "");
                return lista;
            }
            else
            {
                return "La lista está vacía";
            }
        }
    }
}
