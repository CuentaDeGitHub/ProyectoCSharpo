using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEstructurasCSharp
{
    class ListaDoblementeEnlazada   
    {
        private NodoDoble head; 
        public NodoDoble Head
        {
            get { return head; }
            set { head = value; }
        }

        public ListaDoblementeEnlazada()
        {
            head = null;
        }

        public void Insertar(NodoDoble n)
        {
           
            if (head == null)
            {
                head = n;
                return;
            }
                
            if (n.Dato < head.Dato)
            {
                n.Siguiente = head;
                head.Anterior = n;
                head = n;
                return;
            }

            NodoDoble h = head;

            while (h.Siguiente != null)
            {
                if (h.Siguiente.Dato > n.Dato)
                {
                    break;
                }
                h = h.Siguiente; 
            }

            n.Siguiente = h.Siguiente;
            n.Anterior = h;
            if (h.Siguiente != null)
            {
                h.Siguiente.Anterior = n;
            }
            h.Siguiente = n;

            return;
        }

        public void Eliminar(int dato)
        {
            if (head != null)
            {
                if (head.Dato == dato)
                {

                    head = head.Siguiente;      
                    head.Anterior = null;
                    return;
                }
                NodoDoble h = head;

                while (h.Siguiente != null)
                {
                    if (h.Siguiente.Dato == dato)
                    {
                        break;
                    }
                    h = h.Siguiente;
                }
                if(h.Siguiente.Siguiente == null)
                {
                    h.Siguiente = null;
                }
                else
                {
                    h.Siguiente = h.Siguiente.Siguiente;
                    h.Siguiente.Anterior = h;

                }
            }
        }

        public override string ToString()
        {
            string lista = "";
            NodoDoble h = head;
            if (h != null)
            {
                lista += h.ToString();

                h = h.Siguiente;
                while (h != null)
                {
                    lista += "," + h.ToString();

                    h = h.Siguiente;
                }
                return lista;
            }
            else
            {
                return "La lista esta vacia";
            }
        }

        public bool BuscarDato(int a)
        {
            NodoDoble h = head;
            if (h != null)
            {
                while (h != null)
                {
                    if (h.Dato == a)
                    {
                        return true;
                    }
                    h = h.Siguiente;
                }
            }
            return false;
        }

        public int ContarNodos()
        {
            int contador = 0;
            NodoDoble h = head;
            while (h != null)
            {
                contador++;
                h = h.Siguiente;
            }
            return contador;
        }


    }
}
