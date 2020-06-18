using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_Singleton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            txtContador.Text = Singleton.Instancia().Abrir().ToString();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            txtContador.Text = Singleton.Instancia().Cerrar().ToString();
        }
    }
}
