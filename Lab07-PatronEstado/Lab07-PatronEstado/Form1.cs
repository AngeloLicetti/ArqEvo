using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab07_PatronEstado
{
    public partial class Form1 : Form
    {
        Puerta puerta;
        public Form1()
        {
            InitializeComponent();
            puerta = new Puerta();
            puerta.setEstado(new Cerrado(puerta));
            txtEstado.Text = puerta.getEstado();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            puerta.abrir();
            txtEstado.Text = puerta.getEstado();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            puerta.cerrar();
            txtEstado.Text = puerta.getEstado();
        }

        private void btnArmar_Click(object sender, EventArgs e)
        {
            puerta.armar();
            txtEstado.Text = puerta.getEstado();
        }

        private void btnDesarmar_Click(object sender, EventArgs e)
        {
            puerta.desarmar();
            txtEstado.Text = puerta.getEstado();
        }

        private void btnReparar_Click(object sender, EventArgs e)
        {
            puerta.reparar();
            txtEstado.Text = puerta.getEstado();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            puerta.test();
            txtEstado.Text = puerta.getEstado();
        }

        private void btnEndTest_Click(object sender, EventArgs e)
        {
            puerta.endTest();
            txtEstado.Text = puerta.getEstado();
        }
    }
}
