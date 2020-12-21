using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoEstructurasCSharp
{
    public partial class MatrizPeso : Form
    {
        List<NodoGrafo> grafo = new List<NodoGrafo>();
        public MatrizPeso()
        {
            InitializeComponent();
        }

        public MatrizPeso(List<NodoGrafo> gr)
        {
            InitializeComponent();
            grafo = gr;
        }

        private void MatrizPeso_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 0;
            dataGridView1.ColumnCount = grafo.Count;
            dataGridView1.RowCount = 1;
            dataGridView1.RowCount = grafo.Count;
            for (int i = 0; i < grafo.Count; i++)
            {
                dataGridView1.Columns[i].Name = i.ToString();
            }

            for (int i = 0; i < grafo.Count; i++)
            {
                for (int j = 0; j < grafo.Count; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = 0;
                }
            }

            for (int i = 0; i < grafo.Count; i++)
            {
                for (int j = 0; j < grafo[i].aristas.Count(); j++)
                {
                    dataGridView1.Rows[i].Cells[grafo[i].aristas[j].getDestino()].Value = grafo[i].aristas[j].getPeso();
                }
            }
        }
    }
}
