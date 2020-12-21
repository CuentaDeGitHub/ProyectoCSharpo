using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoEstructurasCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cola = new FormularioCola();
            cola.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var pila = new FormularioPila();
            pila.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var listaEnlazada = new FormularioListaEnlazada();
            listaEnlazada.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var listaCircular = new ListaCircular();
            listaCircular.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var listaDoble = new formularioListaDoble();
            listaDoble.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var listaCircularDoble = new ListaCircularDoble();
            listaCircularDoble.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var net = new FormularioGrafo();
            net.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var arboles = new FormularioArbol();
            arboles.Show();
        }
    }
}
