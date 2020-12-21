using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEstructurasCSharp
{
    class NodoDoble 
    {

        private int dato;
        private NodoDoble siguiente;
        private NodoDoble anterior;
        public int Dato
        {
            get { return dato; }
            set { dato = value; }
        }
        public NodoDoble Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }
        public NodoDoble Anterior
        {
            get { return anterior; }
            set { anterior = value; }
        }
        public NodoDoble()
        {
            dato = 0;
            siguiente = null;
            anterior = null;
        }


        public override string ToString()
        {
            return dato + "";
        }


    }
}
