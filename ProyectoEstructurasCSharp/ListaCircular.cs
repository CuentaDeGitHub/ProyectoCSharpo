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
    public partial class ListaCircular : Form
    {
        Nodo n;
        ListaCircularClase miListaCircular = new ListaCircularClase();
        public ListaCircular()
        {
            InitializeComponent();
        }

        private void ListaCircular_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!miListaCircular.BuscarDato(int.Parse(txtDato.Text)))
                {
                    n = new Nodo();
                    n.Dato = int.Parse(txtDato.Text);
                    miListaCircular.Agregar(n);
                    lblLista.Text = miListaCircular.ToString();
                    txtDato.Clear();
                }
                else
                {
                    MessageBox.Show("El dato ya existe en la lista.");
                    txtDato.Clear();
                }
            }
            catch
            {
                MessageBox.Show("Introduzca un dato válido.");
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                int dato = int.Parse(txtDatoBorrar.Text);

                if (!miListaCircular.BuscarDato(dato))
                {
                    MessageBox.Show("No se encontró el dato");
                }
                else
                {
                    miListaCircular.Borrar(dato);
                    lblLista.Text = miListaCircular.ToString();
                }
                txtDatoBorrar.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Introduzca un dato válido.");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int dato = int.Parse(txtDatoBuscar.Text);
                bool resultado = miListaCircular.BuscarDato(dato);
                if (resultado == true)
                {
                    MessageBox.Show("El dato se encuentra dentro de la lista");
                }
                else
                {
                    MessageBox.Show("El dato no se encuentra dentro de la lista");
                }
                txtDatoBuscar.Clear();
            }
            catch
            {
                MessageBox.Show("Introduzca un dato valido");
                txtDatoBuscar.Clear();
            }

        }

        private void btnEliminarLista_Click(object sender, EventArgs e)
        {
            miListaCircular.Head = null;
            lblLista.Text = miListaCircular.ToString();
            MessageBox.Show("Lista eliminada");
        }

        private void btnGuarda_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog Dialogo = new FolderBrowserDialog();
            try
            {
                if (Dialogo.ShowDialog() == DialogResult.OK)
                {
                    string dato = lblLista.Text;
                    string nombreDelArchivo;
                    if (txtArchivo.Text == "")
                    {
                        nombreDelArchivo = "ListaCircular";
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
                    MessageBox.Show("Datos guardados");
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
            OpenFileDialog Seleccionar = new OpenFileDialog();
            try
            {
                if (Seleccionar.ShowDialog() == DialogResult.OK)
                {
                    miListaCircular.Head = null;
                    int contador = 0;
                    string ruta = Seleccionar.FileName;
                    string linea = File.ReadAllText(ruta);
                    string[] Lista = linea.Split(',');
                    foreach (string i in Lista)
                    {
                        n = new Nodo();
                        n.Dato = int.Parse(Lista[contador]);
                        miListaCircular.Agregar(n);
                        lblLista.Text = miListaCircular.ToString();
                        contador++;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error al cargar");
                miListaCircular.Head = null;
                lblLista.Text = miListaCircular.ToString();
                return;
            }
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Elementos dentro de la lista : " + miListaCircular.ContarNodos());
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
