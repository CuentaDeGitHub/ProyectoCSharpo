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
    public partial class ListaCircularDoble : Form
    {
        NodoDoble n;
        ListaCircDoble miLista = new ListaCircDoble();
        public ListaCircularDoble()
        {
            InitializeComponent();
        }

    
        private void ListaCircularDoble_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int dato = int.Parse(txtDato.Text);
                if (miLista.Buscar(dato) == false)
                {
                    n = new NodoDoble();
                    n.Dato = dato;
                    miLista.Agregar(n);
                    lblLista.Text = miLista.ToString();
                    txtDato.Clear();
                    return;
                }
                MessageBox.Show("El dato ya se encuentra dentro de la lista");
            }
            catch
            {
                MessageBox.Show("Introduzca un dato valido");
                txtDato.Clear();
                return;
            }
            
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                int dato = int.Parse(txtDatoBorrar.Text);
                if (miLista.Buscar(dato) == true)
                {
                    miLista.Eliminar(dato);
                    lblLista.Text = miLista.ToString();
                    txtDatoBorrar.Clear();
                    return;
                }
                MessageBox.Show("El dato no se encuentra dentro de la lista");
                txtDatoBorrar.Clear();
            }
            catch
            {
                MessageBox.Show("Introduzca un dato valido");
                txtDatoBorrar.Clear();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int dato = int.Parse(txtDatoBuscar.Text);
                if(miLista.Buscar(dato) == true)
                {
                    MessageBox.Show("El dato se encuentra dentro de la lista");
                }
                else
                {
                    MessageBox.Show("El dayo no se encuentra dentro de la lista");
                }
                txtDatoBuscar.Clear();
            }
            catch
            {
                MessageBox.Show("Introduzca un dato valido para buscar");
                txtDatoBuscar.Clear();
            }
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Numero de elementos en la lista : " + miLista.ContarNodos());
        }

        private void btnEliminarLista_Click(object sender, EventArgs e)
        {
            miLista.Head = null;
            lblLista.Text = miLista.ToString();
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
                        nombreDelArchivo = "ListaCircDoble";
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
                        miLista.Agregar(n);
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
                return;
            }
        }
    }
}
