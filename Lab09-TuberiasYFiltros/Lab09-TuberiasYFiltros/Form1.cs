using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab09_TuberiasYFiltros
{
    public partial class Form1 : Form
    {
        StringPipe tuberia;
        public Form1()
        {
            InitializeComponent();
            tuberia = new StringPipe();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tuberia.reset();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            lbFiltros.Items.Clear();
            foreach (AbstractFilter filtro in tuberia.Filtros)
            {
                lbFiltros.Items.Add(filtro.ToString());
            }
            txtOutput.Text = tuberia.filtrar(txtInput.Text);
        }

        private void cbEliminarBlancos_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEliminarBlancos.Checked)
            {
                tuberia.add(new EliminarBlancos());
            }
        }

        private void cbWordCount_CheckedChanged(object sender, EventArgs e)
        {
            if (cbWordCount.Checked)
            {
                tuberia.add(new WordCount());
            }
        }

        private void cbReverse_CheckedChanged(object sender, EventArgs e)
        {
            if (cbReverse.Checked)
            {
                tuberia.add(new Reverse());
            }
        }
    }
}
