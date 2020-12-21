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
    public partial class FormularioListaEnlazada : Form
    {
        Nodo n;
        ListaEnlazada miListaEnlazada = new ListaEnlazada();
        public FormularioListaEnlazada()
        {
            InitializeComponent();
        }

      

        private void btnCargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog Seleccionar = new OpenFileDialog();
            try
            {
                if (Seleccionar.ShowDialog() == DialogResult.OK)
                {
                    miListaEnlazada.Head = null;
                    int contador = 0;
                    string ruta = Seleccionar.FileName;
                    string linea = File.ReadAllText(ruta);
                    string[] Lista = linea.Split(',');
                    foreach (string i in Lista)
                    {
                        n = new Nodo();
                        n.Dato = int.Parse(Lista[contador]);
                        miListaEnlazada.Agregar(n);
                        lblLista.Text = miListaEnlazada.ToString();
                        contador++;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error al cargar");
                miListaEnlazada.Head = null;
                lblLista.Text = miListaEnlazada.ToString();
            }
        }

        private void FormularioListaEnlazada_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!miListaEnlazada.BuscarDato(int.Parse(txtNodo.Text)))
                {
                    n = new Nodo();
                    n.Dato = int.Parse(txtNodo.Text);
                    miListaEnlazada.Agregar(n);
                    lblLista.Text = miListaEnlazada.ToString();
                    txtNodo.Clear();
                    return;
                }
                MessageBox.Show("El dato ya existe en la lista");
                txtNodo.Clear();

            }
            catch
            {
                MessageBox.Show("Introduzca un numero valido");
                txtNodo.Clear();
            }
            
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int dato = int.Parse(txtDatoBorrar.Text);
            if (!miListaEnlazada.BuscarDato(dato))
            {
                MessageBox.Show("No se encontro el dato");
                txtDatoBorrar.Clear();
                return;
            }
            miListaEnlazada.Borrar(dato);
            lblLista.Text = miListaEnlazada.ToString();
            txtDatoBorrar.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int datoBuscar = int.Parse(txtDatoBuscar.Text);
                if (miListaEnlazada.BuscarDato(datoBuscar) == true)
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
                MessageBox.Show("El dato introducido no es valido para buscar");
            }
        }


        private void btnContar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Numero de nodos en la lista : " + miListaEnlazada.ContarNodos());
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
                        nombreDelArchivo = "ListaEnlazada";
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            miListaEnlazada.Head = null;
            lblLista.Text = miListaEnlazada.ToString();
            MessageBox.Show("Lista enlazada eliminada");
        }
    }
}
