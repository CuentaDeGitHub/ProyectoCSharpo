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
    public partial class FormularioCola : Form
    {
        Nodo n;

        Cola MiCola = new Cola();

        public FormularioCola()
        {
            InitializeComponent();
        }


        private void FormularioCola_Load(object sender, EventArgs e)
        {
        }

        private void btnEncolar_Click(object sender, EventArgs e)
        {
            try
            {
                n = new Nodo();
                n.Dato = int.Parse(txtDato.Text);
                MiCola.Encolar(n);
                lblCola.Text = MiCola.ToString();
                txtDato.Clear();
            }
            catch
            {
                MessageBox.Show("Error al convertir el dato a entero");
                txtDato.Clear();
            }
        }

        private void btnDesencolar_Click(object sender, EventArgs e)
        {
            MiCola.Desencolar();
            lblCola.Text = MiCola.ToString();
        }

        private void btnFrente_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El dato frontal es : " + MiCola.Front());
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog Dialogo = new FolderBrowserDialog();
            try
            {
                if (Dialogo.ShowDialog() == DialogResult.OK)
                {
                    string dato = lblCola.Text;
                    string nombreDelArchivo;
                    if (txtArchivo.Text == "")
                    {
                        nombreDelArchivo = "Cola";
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
                    txtArchivo.Clear();
                }
            }
            catch
            {
                MessageBox.Show("Error al guardar");
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog Seleccionar = new OpenFileDialog();
                if (Seleccionar.ShowDialog() == DialogResult.OK)
                {
                    MiCola.Head = null;
                    int contador = 0;
                    string ruta = Seleccionar.FileName;
                    string linea = File.ReadAllText(ruta);
                    string[] Lista = linea.Split(',');
                    foreach (string i in Lista)
                    {
                        n = new Nodo();
                        n.Dato = int.Parse(Lista[contador]);
                        MiCola.Encolar(n);
                        contador++;
                    }
                    lblCola.Text = MiCola.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Error al cargar");
                MiCola.Head = null;
                MiCola.Tail = null;
                lblCola.Text = MiCola.ToString();

            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MiCola.Head = null;
            MiCola.Tail = null;
            lblCola.Text = MiCola.ToString();
            MessageBox.Show("Cola eliminada");
        }
    }
}
