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
    public partial class FormularioCountingSort : Form
    {
        Random r = new Random();
        int valorMayor = 0;
        int[] arregloInicial;
        int[] arregloAuxiliar;
        int[] arregloOrdenado;
        Stopwatch stopWatch = new Stopwatch();

        public FormularioCountingSort()
        {
            InitializeComponent();
        }

        public void OrdenarEInvertir(int tamaño, int minimo, int maximo)
        {
            stopWatch.Start();
            arregloInicial = new int[tamaño];
            for (int i = 0; i < arregloInicial.Length; i++)
            {
                arregloInicial[i] = r.Next(minimo, maximo);
            }
            lblOriginal.Text = ImprimirArreglo(arregloInicial);

            for (int i = 0; i < arregloInicial.Length; i++)
            {
                if (arregloInicial[i] > valorMayor)
                {
                    valorMayor = arregloInicial[i];
                }
            }

            arregloAuxiliar = new int[valorMayor + 1];
            int posicion;
            for (int i = 0; i < arregloInicial.Length; i++)
            {
                posicion = arregloInicial[i];
                arregloAuxiliar[posicion]++;
            }

            for (int i = 1; i < arregloAuxiliar.Length; i++)
            {
                arregloAuxiliar[i] = arregloAuxiliar[i - 1] + arregloAuxiliar[i];
            }   

            for (int i = arregloAuxiliar.Length - 1; i != 0; i--)
            {
                arregloAuxiliar[i] = arregloAuxiliar[i - 1];
            }
            arregloAuxiliar[0] = 0;

            arregloOrdenado = new int[arregloInicial.Length];
            int valor;  
            for (int i = 0; i < arregloInicial.Length; i++)
            {
                valor = arregloInicial[i];
                posicion = arregloAuxiliar[valor];
                arregloOrdenado[posicion] = valor;
                arregloAuxiliar[valor]++;
            }
            lblOrdenado.Text = ImprimirArreglo(arregloOrdenado);
            Array.Reverse(arregloOrdenado);
            lblInvertido.Text = ImprimirArreglo(arregloOrdenado);
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            lblTiempo.Text = ts + "";
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
            
        private void btnCrearArreglo_Click(object sender, EventArgs e)
        {
            try
            {
                int maximo = int.Parse(txtMax.Text);
                int minimo = int.Parse(txtMin.Text);
                int tamaño = int.Parse(txTamaño.Text);
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
                OrdenarEInvertir(tamaño, minimo, maximo);
                groupBox1.Visible = true;


            }
            catch
            {
                MessageBox.Show("Introduzca datos validos");
                return;
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            int tamaño = r.Next(3, 20);
            int minimo = r.Next(0, 5);
            int maximo = r.Next(minimo, 25);
            OrdenarEInvertir(tamaño, minimo, maximo);
            groupBox1.Visible = true;
        }

        private void FormularioCountingSort_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }
    }
}
