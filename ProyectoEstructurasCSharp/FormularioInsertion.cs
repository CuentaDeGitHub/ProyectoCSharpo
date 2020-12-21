using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ProyectoEstructurasCSharp
{
    public partial class FormularioInsertion : Form
    {
        int[] arreglo;
        Stopwatch stopwatch = new Stopwatch();
        Random r = new Random();
        int comparaciones = 0;
        int intercambios = 0;
        public FormularioInsertion()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                int tamaño = int.Parse(txtTamaño.Text);
                int minimo = int.Parse(txtMinimo.Text);
                int maximo = int.Parse(txtMaximo.Text);
                if (tamaño <= 0)
                {
                    MessageBox.Show("El tamaño no puede ser menor o igual a 0");
                    return;
                }
                if (maximo <= minimo)
                {
                    MessageBox.Show("El maximo no puede ser igual o menor que el minimo");
                    return;
                }
                txtMaximo.Clear();
                txtMinimo.Clear();
                txtTamaño.Clear();
                crearArreglo(tamaño, minimo, maximo);
                Ordenar(arreglo);

            }
            catch
            {
                MessageBox.Show("Introduzca datos validos");
            }
        }

        public void Ordenar(int[] arreglo)
        {
            comparaciones = 0;
            intercambios = 0;
            lblArregloOriginal.Text = MostrarLista();
            stopwatch.Restart();
            int n = arreglo.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = arreglo[i];
                int j = i - 1;

                while (j >= 0 && arreglo[j] > key)
                {
                    comparaciones++;
                    arreglo[j + 1] = arreglo[j];
                    j = j - 1;
                }
                arreglo[j + 1] = key;
                intercambios++;
            }
            stopwatch.Stop();
            lblArregloOrdenado.Text = MostrarLista();
            string time = stopwatch.Elapsed.TotalMilliseconds + " ms.";
            lblTiempo.Text = time;
            lblComparaciones.Text = comparaciones + "";
            lblIntercambios.Text = intercambios + "";

        }
        public string MostrarLista()
        {
            string numeros = "";
            if (arreglo.Length != 0)
            {
                for (int i = 0; i < arreglo.Length; i++)
                {
                    numeros += arreglo[i] + ", ";
                }

            }
            return numeros;

        }

        private void btnAleatorio_Click(object sender, EventArgs e)
        {
            int tamaño = r.Next(1, 18);
            int minimo = r.Next(0, 50);
            int maximo = r.Next(minimo, 100);
            crearArreglo(tamaño, minimo, maximo);
            Ordenar(arreglo);
        }

        public void crearArreglo(int tamaño, int minimo, int maximo)
        {
            arreglo = new int[tamaño];
            for (int i = 0; i < arreglo.Length; i++)
            {
                arreglo[i] = r.Next(minimo, maximo);
            }
            lblArregloOriginal.Text = MostrarLista();
        }
    }
}
