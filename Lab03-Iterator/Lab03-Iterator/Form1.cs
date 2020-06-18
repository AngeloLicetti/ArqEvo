using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_Iterator
{
    public partial class Form1 : Form
    {
        Iterator i;

        public Form1()
        {
            InitializeComponent();
            i = new Iterator(mlbLista);
            i.modoNormal();
        }

        private void btnTop_Click(object sender, EventArgs e)
        {
            txtSelected.Text = i.Top().ToString();
        }

        private void btnBottom_Click(object sender, EventArgs e)
        {
            txtSelected.Text = i.Bottom().ToString();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            txtSelected.Text = i.Next().ToString();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            txtSelected.Text = i.Previous().ToString();
        }

        private void btnCentral_Click(object sender, EventArgs e)
        {
            txtSelected.Text = i.Central().ToString();
        }

        private void rbNormal_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNormal.Checked)
            {
                i.modoNormal();
            }
        }

        private void rbPar_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPar.Checked)
            {
                i.modoPar();
            }
        }

        private void rbImpar_CheckedChanged(object sender, EventArgs e)
        {
            if (rbImpar.Checked)
            {
                i.modoImpar();
            }
        }
    }
}
