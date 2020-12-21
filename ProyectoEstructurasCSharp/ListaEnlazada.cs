using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoEstructurasCSharp
{
    class ListaEnlazada
    {
        private Nodo head;
        public Nodo Head
        {
            get { return head; }
            set { head = value; }
        }
        public ListaEnlazada()
        {
            head = null;
        }
        public ListaEnlazada(Nodo n)
        {
            head = n;
        }

        public void Borrar(int dato)
        {
            if(head != null)
            {
                if(head.Dato == dato)
                {
                    head = head.Siguiente;
                    return;
                }
                Nodo h = head;
                while (h.Siguiente != null)
                {
                    if(h.Siguiente.Dato == dato)
                    {
                        h.Siguiente = h.Siguiente.Siguiente;
                        return;
                    }
                    h = h.Siguiente;
                }
                MessageBox.Show("No se encontro el dato a eliminar");
            }
        }
        public void Agregar(Nodo n)
        {
            if (head == null)
            {
                head = n;
                return;
            }
            if (n.Dato < head.Dato)
            {
                n.Siguiente = head;
                head = n;
                return;
            }
            Nodo h = head;
            while (h.Siguiente != null)
            {
                if (h.Siguiente.Dato > n.Dato)
                {
                    break;
                }
                h = h.Siguiente; 
            }
            if (h.Siguiente != null)
            {
                n.Siguiente = h.Siguiente;
                h.Siguiente = n;
                return;
            }
            h.Siguiente = n;
        }
        public override string ToString()
        {
            string lista = "";
            Nodo h = head;
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
            Nodo h = head;
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
            Nodo h = head;
            while (h != null)
            {
                contador++;
                h = h.Siguiente;
            }
            return contador;
        }
    }
}
