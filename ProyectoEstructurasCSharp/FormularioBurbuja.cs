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
    public partial class FormularioBurbuja : Form
    {
        int aux;
        int comparaciones;
        int intercambios;
        int[] lista;
        Stopwatch stopwatch = new Stopwatch();
        Random r = new Random();
        public FormularioBurbuja()
        {
            InitializeComponent();
        }

        private void FormularioBurbuja_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
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
                if(maximo <= minimo)
                {
                    MessageBox.Show("El maximo no puede ser igual o menor que el minimo");
                    return;
                }
                txtMaximo.Clear();
                txtMinimo.Clear();
                txtTamaño.Clear();
                intercambios = 0;
                comparaciones = 0; 
                OrdenarArreglo(tamaño,minimo,maximo);

            }
            catch
            {
                MessageBox.Show("Introduzca datos validos");
            }
          

        }
        public void OrdenarArreglo(int tamaño,int minimo,int maximo)
        {
            groupBox1.Visible = true;
            lista = new int[tamaño];
            Random random = new Random();
            for (int i = 0; i < lista.Length; i++)
            {
                lista[i] = random.Next(minimo, maximo);
            }
            lblArregloOriginal.Text = MostrarLista();

            stopwatch.Start();

            for (int i = 1; i < lista.Length; i++)
            {
                for (int j = 0; j < lista.Length - 1; j++)
                {
                    comparaciones++;
                    if (lista[j] > lista[j + 1])
                    {
                        aux = lista[j];
                        lista[j] = lista[j + 1];
                        lista[j + 1] = aux;
                        intercambios++;
                    }
                }
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
            if (lista.Length != 0)
            {
                for (int i = 0; i < lista.Length; i++)
                {
                    numeros += lista[i] + ", ";
                }
                
            }
            return numeros;

        }

        private void btnAleatorio_Click(object sender, EventArgs e)
        {
            int tamaño = r.Next(1, 18);
            int minimo = r.Next(0, 50);
            int maximo = r.Next(minimo, 100);
            comparaciones = 0;
            intercambios = 0;
            OrdenarArreglo(tamaño, minimo, maximo);
        }
    }
}
