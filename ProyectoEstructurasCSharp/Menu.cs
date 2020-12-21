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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnFormEstructuras_Click(object sender, EventArgs e)
        {
            Form1 FormularioEstructuras = new Form1();
            FormularioEstructuras.Show();
        }

        private void btnFormAlgoritmos_Click(object sender, EventArgs e)
        {
            FormularioAlgoritmos FormAlgortmos = new FormularioAlgoritmos();
            FormAlgortmos.Show();
        }
    }
}
