using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04_Patron_COR
{
    public partial class Form1 : Form
    {
        Handler cadena;
        public Form1()
        {
            InitializeComponent();
            cadena = new Handler1000(new Handler10000(new Handler100000(new Handler1000000())));
        }

        private void btnCalcularImpuesto_Click(object sender, EventArgs e)
        {
            txtImpuesto.Text = cadena.calcularImpuesto(Convert.ToDouble(txtMonto.Text)).ToString();
        }
    }
}
