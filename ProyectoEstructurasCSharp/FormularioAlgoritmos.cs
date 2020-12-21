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
    public partial class FormularioAlgoritmos : Form
    {
        public FormularioAlgoritmos()
        {
            InitializeComponent();
        }

        private void btnCountingSort_Click(object sender, EventArgs e)
        {
            FormularioCountingSort Counting = new FormularioCountingSort();
            Counting.Show();
        }

        private void btnBubble_Click(object sender, EventArgs e)
        {
            FormularioBurbuja Burbuja = new FormularioBurbuja();
            Burbuja.Show();
        }

        private void btnCockTail_Click(object sender, EventArgs e)
        {
            FormularioCocktail Cocktail = new FormularioCocktail();
            Cocktail.Show();
        }

        private void btnShell_Click(object sender, EventArgs e)
        {
            FormularioShell Shell = new FormularioShell();
            Shell.Show();
        }

        private void btnRadix_Click(object sender, EventArgs e)
        {
            FormularioRadix Radiz = new FormularioRadix();
            Radiz.Show();
        }

        private void btnInsertion_Click(object sender, EventArgs e)
        {
            FormularioInsertion Insertion =  new FormularioInsertion();
            Insertion.Show();
        }
    }
}
