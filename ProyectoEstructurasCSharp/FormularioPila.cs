using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProyectoEstructurasCSharp
{
    public partial class FormularioPila : Form
    {
        Nodo n;
        Pila miPila = new Pila();
        public FormularioPila()
        {
            InitializeComponent();
        }



        private void FormularioPila_Load(object sender, EventArgs e)
        {

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog Seleccionar = new OpenFileDialog();  
                if (Seleccionar.ShowDialog() == DialogResult.OK)
                {
                    miPila.Top = null;
                    string ruta = Seleccionar.FileName;
                    string linea = File.ReadAllText(ruta);
                    string[] Pila = linea.Split(',');
                    int contador = Pila.Length - 1;
                    foreach (string i in Pila)
                    {
                        n = new Nodo();
                        n.Dato = int.Parse(Pila[contador]);
                        miPila.Push(n);
                        contador--;
                    }
                    lblPila.Text = miPila.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Error al cargar");
                miPila.Top = null;
                lblPila.Text = miPila.ToString();
            }
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            try
            {
                int dato = int.Parse(txtDato.Text);
                n = new Nodo();
                n.Dato = dato;
                miPila.Push(n);
                txtDato.Clear();
                lblPila.Text = miPila.ToString();
            }
            catch
            {
                txtDato.Clear();
                MessageBox.Show("Error al convertir dato a entero");
            }
          
        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            n = new Nodo();
            n = miPila.Pop();
            MessageBox.Show("Dato eliminado de la pila : " + n.Dato);
            lblPila.Text = miPila.ToString();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Numero de elementos en la pila : " + miPila.Count);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
                try
            {
                FolderBrowserDialog Dialogo = new FolderBrowserDialog();
                if (Dialogo.ShowDialog() == DialogResult.OK)
                {
                    string dato = lblPila.Text;
                    string nombreDelArchivo;
                    if (txtArchivo.Text == "")
                    {
                        nombreDelArchivo = "Pila";
                    }
                    else
                    {
                        nombreDelArchivo = txtArchivo.Text;
                    }
                    string ruta = Dialogo.SelectedPath + "\\" + nombreDelArchivo + ".txt";
                    using (var writer = new StreamWriter(ruta))
                    {
                        writer.Close();
                    }
                    File.WriteAllText(ruta, dato);
                    MessageBox.Show("Datos guardados en el archivo : " + nombreDelArchivo + ".txt");
                    }
            }
            catch
            {
                MessageBox.Show("Error al guardar");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            miPila.Top = null;
            lblPila.Text = miPila.ToString();
            MessageBox.Show("Pila eliminada");

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
