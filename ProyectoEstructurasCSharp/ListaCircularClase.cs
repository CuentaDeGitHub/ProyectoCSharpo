using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEstructurasCSharp
{
    class ListaCircularClase
    {
        private Nodo head;
        public Nodo Head
        {
            get { return head; }
            set { head = value; }
        }
        public ListaCircularClase()
        {
            head = null;
        }

        public void Agregar(Nodo n)
        {
            if (head == null)
            {
                head = n;
                n.Siguiente = n;
                return;
            }
              Nodo h = head;
            if (n.Dato < head.Dato)
            {
                while (h.Siguiente != head)
                {
                    h = h.Siguiente;
                }
                h.Siguiente = n;
                n.Siguiente = head;
                head = n;
                return;
            }
          
            //insertar al final
            while (h.Siguiente != head)
            {
                if (n.Dato < h.Siguiente.Dato)
                {
                    break;
                }
                h = h.Siguiente;
            }

            n.Siguiente = h.Siguiente;
            h.Siguiente = n;


        }

        public void Borrar(int dato)
        {
            Nodo h = head;
            if (head != null)
            {
                if (head.Dato == dato)
                {
                    while (h.Siguiente != head)
                    {
                        h = h.Siguiente;
                    }

                    head = head.Siguiente;
                    h.Siguiente = head;
                    return;
                }

                    while (h.Siguiente.Dato != dato)
                    {
                        h = h.Siguiente;
                    }
                    h.Siguiente = h.Siguiente.Siguiente;
                
            }
        }

        public bool BuscarDato(int a)
        {
            Nodo h = head;
            if (h != null)
            {
                do
                {
                    if (h.Dato == a)
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
            Nodo h = head;
            do
            {
                contador++;
                h = h.Siguiente;
            } while (h != head);
            return contador;
        }

        public override string ToString()
        {
            string lista = "";
            Nodo h = head;
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
