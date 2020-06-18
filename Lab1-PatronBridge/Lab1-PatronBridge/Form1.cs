using Lab1_PatronBridge.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_PatronBridge
{
    public partial class Form1 : Form
    {
        FechaBridge fechaBridge;
        public Form1()
        {
            InitializeComponent();
        }

        private void reinicializarFechaBridge()
        {
            if (rbDDMMAA.Checked)
            {
                fechaBridge = new FechaBridge(new DDMMAA());
            }
            else if (rbBigEndian.Checked)
            {
                fechaBridge = new FechaBridge(new BigEndian());
            }
            else if (rbMMDDAA.Checked)
            {
                fechaBridge = new FechaBridge(new MMDDAA());
            }
        }

        private void btnHoy_Click(object sender, EventArgs e)
        {
            reinicializarFechaBridge();
            txtFecha.Text = fechaBridge.hoy();
        }

        private void btnMañana_Click(object sender, EventArgs e)
        {
            reinicializarFechaBridge();
            txtFecha.Text = fechaBridge.mañana();
        }

        private void btnAyer_Click(object sender, EventArgs e)
        {
            reinicializarFechaBridge();
            txtFecha.Text = fechaBridge.ayer();
        }
    }
}
