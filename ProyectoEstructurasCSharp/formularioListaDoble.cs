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
    public partial class formularioListaDoble : Form
    {
        NodoDoble n;
        ListaDoblementeEnlazada miLista = new ListaDoblementeEnlazada();
        public formularioListaDoble()
        {
            InitializeComponent();
        }

        private void formularioListaDoble_Load(object sender, EventArgs e)
        {

        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!miLista.BuscarDato(int.Parse(txtNodo.Text)))
                {
                    n = new NodoDoble();
                    n.Dato = int.Parse(txtNodo.Text);
                    miLista.Insertar(n);
                    lblLista.Text = miLista.ToString();
                    txtNodo.Clear();
                    return;
                }
                MessageBox.Show("El dato ya existe en la lista");
                txtNodo.Clear();
            }
            catch
            {
                MessageBox.Show("Introduzca un dato valido");
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                int dato = int.Parse(txtDatoBorrar.Text);
                if (!miLista.BuscarDato(dato))
                {
                    MessageBox.Show("No se encontro el dato");

                }
                else
                {
                    miLista.Eliminar(dato);
                    lblLista.Text = miLista.ToString();
                }
                txtDatoBorrar.Clear();
            }
            catch
            {
                MessageBox.Show("Introduzca un dato valido para eliminar");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int datoBuscar = int.Parse(txtDatoBuscar.Text);
                if (miLista.BuscarDato(datoBuscar) == true)
                {
                    MessageBox.Show("Dato encontrado dentro de la lista");
                }
                else
                {
                    MessageBox.Show("El dato no se encuentra dentro de la lista");
                }
                txtDatoBuscar.Clear();
            }
            catch
            {

            }
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Numero de elementos en la lista: " + miLista.ContarNodos());
        }

        private void btnEliminarLista_Click(object sender, EventArgs e)
        {
            miLista.Head = null;
            lblLista.Text = miLista.ToString();
            MessageBox.Show("Lista doblemente enlazada eliminada");
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
                        nombreDelArchivo = "ListaDoble";
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
                    miLista.Head = null;
                    int contador = 0;
                    string ruta = Seleccionar.FileName;
                    string linea = File.ReadAllText(ruta);
                    string[] Lista = linea.Split(',');
                    foreach (string i in Lista)
                    {
                        n = new NodoDoble();
                        n.Dato = int.Parse(Lista[contador]);
                        miLista.Insertar(n);
                        lblLista.Text = miLista.ToString();
                        contador++;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error al cargar");
                miLista.Head = null;
                lblLista.Text = miLista.ToString();
            }
        }
    }
}
