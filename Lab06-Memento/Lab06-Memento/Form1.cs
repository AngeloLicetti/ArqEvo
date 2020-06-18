using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab06_Memento
{
    public partial class Form1 : Form
    {
        Guardian guardian = new Guardian();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnControlZ_Click(object sender, EventArgs e)
        {
            guardian.pop();
            actualizarForm();
        }

        private void rbRed_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRed.Checked)
            {
                guardian.push(new Memento(Color.Red, "Rojo"));
                actualizarForm();
            }
        }

        private void rbGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGreen.Checked)
            {
                guardian.push(new Memento(Color.Green, "Verde"));
                actualizarForm();

            }
        }

        private void rbBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBlue.Checked)
            {
                guardian.push(new Memento(Color.Blue, "Azul"));
                actualizarForm();

            }
        }

        private void actualizarForm()
        {
            if (guardian.estadoActual() != null)
            {
                groupBox1.BackColor = guardian.estadoActual().Color;
                lblColor.Text = guardian.estadoActual().NombreColor;
            }
        }
    }
}
