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
    public partial class FormularioCocktail : Form
    {
        int[] arreglo;
        int tamaño;
        int minimo;
        int maximo;
        Stopwatch stopwatch = new Stopwatch();  
        Random r = new Random();

        public FormularioCocktail()
        {
            InitializeComponent();
        }

        private void FormularioCocktail_Load(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                maximo = int.Parse(txtMax.Text);
                minimo = int.Parse(txtMin.Text);
                tamaño = int.Parse(txTamaño.Text);
                if (minimo < 0)
                {
                    MessageBox.Show("El minimo no puede ser menor que 0");
                    return;
                }
                if (tamaño < 0)
                {
                    MessageBox.Show("El tamaño no puede ser un numero negativo");
                    return;
                }
                if (maximo <= minimo)
                {
                    MessageBox.Show("El maximo debe de ser mayor que el minimo");
                    return;
                }
                txtMax.Clear();
                txtMin.Clear();
                txTamaño.Clear();
                CrearArreglo(tamaño, minimo, maximo);
                lblOriginal.Text = ImprimirArreglo(arreglo);
                Ordenar();
                lblOrdenado.Text = ImprimirArreglo(arreglo);


            }
            catch
            {
                MessageBox.Show("Introduza datos validos");
                txtMax.Clear();
                txtMin.Clear();
                txTamaño.Clear();
            }
        
        }

        public void CrearArreglo(int tamaño, int minimo, int maximo)
        {
            arreglo = new int[tamaño];
            for (int i = 0; i < arreglo.Length; i++)
            {
                arreglo[i] = r.Next(minimo, maximo);
            }
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

        public void Ordenar()
        {
            stopwatch.Start();
            int derecha = arreglo.Length - 1;
            int izquierda = 0;
            int ultimo = 0;
            int auxiliar = 0;
            int comparaciones = 0;
            int intercambios = 0;

            do
            {
                for(int i = izquierda; i < derecha; i++)
                {
                    comparaciones++;
                    if(arreglo[i] > arreglo[i+1])
                    {
                        auxiliar = arreglo[i];
                        arreglo[i] = arreglo[i + 1];
                        arreglo[i + 1] = auxiliar;
                        ultimo = i;
                        intercambios++;
                    }
                }
                derecha = ultimo;

                for(int j = derecha; j > izquierda; j--)
                {
                    comparaciones--;
                    if (arreglo[j - 1] > arreglo[j])
                    {
                        auxiliar = arreglo[j];
                        arreglo[j] = arreglo[j - 1];
                        arreglo[j - 1] = auxiliar;
                        ultimo = j;
                        intercambios++;
                    }
                }
                izquierda = ultimo;

            } while (izquierda < derecha);

            lblComparaciones.Text = comparaciones + "";
            lblIntercambios.Text = intercambios + "";
            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;
            lblTiempo.Text = ts + "";
        }

        private void btnAleatorio_Click(object sender, EventArgs e)
        {
            tamaño = r.Next(3, 20);
            minimo = r.Next(0, 5);
            maximo = r.Next(minimo, 25);
            CrearArreglo(tamaño, minimo, maximo);
            lblOriginal.Text = ImprimirArreglo(arreglo);
            Ordenar();
            lblOrdenado.Text = ImprimirArreglo(arreglo);
            txtMax.Clear();
            txtMin.Clear();
            txTamaño.Clear();

        }
    }
}
