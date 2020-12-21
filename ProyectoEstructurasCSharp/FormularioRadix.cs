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
    public partial class FormularioRadix : Form
    {
        int[] arreglo;
        Random r = new Random();
        Stopwatch stopwatch = new Stopwatch();

        public FormularioRadix()
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
                // intercambios = 0;
                // comparaciones = 0;
                CrearArreglo(tamaño, minimo, maximo);
                lblArregloOriginal.Text = ImprimirArreglo(arreglo);
                OrdenarRadiz(arreglo);
                lblArregloOrdenado.Text = ImprimirArreglo(arreglo);

            }
            catch
            {
                MessageBox.Show("Introduzca datos validos");
            }
        }

        public void OrdenarRadiz(int[] arreglo)
        {
            stopwatch.Start();
            int[] auxiliar = new int[arreglo.Length];

            int r = 2;
            int b = 32;

            int[] count = new int[1 << r];
            int[] pref = new int[1 << r];

            int groups = (int)Math.Ceiling((double)b / (double)r);

            int mask = (1 << r) - 1;

            for (int c = 0, shift = 0; c < groups; c++, shift += r)
            {
                for (int j = 0; j < count.Length; j++)
                {   
                    count[j] = 0;
                }
                for (int i = 0; i < arreglo.Length; i++)
                {
                    count[(arreglo[i] >> shift) & mask]++;
                }
                pref[0] = 0;
                for (int i = 1; i < count.Length; i++)
                {
                    pref[i] = pref[i - 1] + count[i - 1];
                }
                for (int i = 0; i < arreglo.Length; i++)
                {
                    auxiliar[pref[(arreglo[i] >> shift) & mask]++] = arreglo[i];
                }
                auxiliar.CopyTo(arreglo, 0);


            }
            stopwatch.Stop();
            string time = stopwatch.Elapsed.TotalMilliseconds + " ms";
            lblTiempo.Text =  time;
        }

        public string ImprimirArreglo(int[] arreglo)
        {
            string colaString = "";
            colaString += arreglo[0];
            for (int i = 0; i < arreglo.Length - 1; i++)
            {
                colaString += "," + arreglo[i + 1];
            }
            return colaString;
        }

        public void CrearArreglo(int tamaño, int minimo, int maximo)
        {
            arreglo = new int[tamaño];
            for (int i = 0; i < arreglo.Length; i++)
            {
                arreglo[i] = r.Next(minimo, maximo);
            }
            lblArregloOriginal.Text = ImprimirArreglo(arreglo);
        }
        private void btnAleatorio_Click(object sender, EventArgs e)
        {
            int tamaño = r.Next(1, 18);
            int minimo = r.Next(0, 50);
            int maximo = r.Next(minimo, 100);
            CrearArreglo(tamaño,minimo,maximo);
            lblArregloOriginal.Text = ImprimirArreglo(arreglo);
            OrdenarRadiz(arreglo);
            lblArregloOrdenado.Text = ImprimirArreglo(arreglo);
        }

        private void FormularioRadix_Load(object sender, EventArgs e)
        {

        }
    }
}
