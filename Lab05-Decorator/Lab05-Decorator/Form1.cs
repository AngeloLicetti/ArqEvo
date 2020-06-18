using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05_Decorator
{
    public partial class Form1 : Form
    {
        Pizza pizza;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPizzaBase_Click(object sender, EventArgs e)
        {
            pizza = new BaseJamon();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            txtPrecio.Text = pizza.Precio().ToString();
        }

        private void cbQueso_CheckedChanged(object sender, EventArgs e)
        {
            if (cbQueso.Checked)
            {
                pizza = new Queso(pizza);
            }
        }

        private void cbJalapeño_CheckedChanged(object sender, EventArgs e)
        {
            if (cbJalapeño.Checked)
            {
                pizza = new Jalapeño(pizza);
            }
        }

        private void cbAnchoas_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAnchoas.Checked)
            {
                pizza = new Anchoas(pizza);
            }
        }

        private void cbTocino_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTocino.Checked)
            {
                pizza = new Tocino(pizza);
            }
        }
    }
}
