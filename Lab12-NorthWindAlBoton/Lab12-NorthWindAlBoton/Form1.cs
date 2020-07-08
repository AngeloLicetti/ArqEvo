using CapaDeDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace Lab12_NorthWindAlBoton
{
    public partial class Form1 : Form
    {
        CtrlVentas ctrlv;
        public Form1()
        {
            InitializeComponent();
            ctrlv = new CtrlVentas();
        }

        private void categoriesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.categoriesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsCategories);

        }

        private void categoriesBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.categoriesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsCategories);

        }

        private void categoriesBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.categoriesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsCategories);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsProducts.Products' Puede moverla o quitarla según sea necesario.
            //this.productsTableAdapter.Fill(this.dsProducts.Products);
            //// TODO: esta línea de código carga datos en la tabla 'dsCategories.Categories' Puede moverla o quitarla según sea necesario.
            //this.categoriesTableAdapter.Fill(this.dsCategories.Categories);

            
            categoriesBindingSource.DataSource = ctrlv.getAllCategories();
            productsBindingSource.DataSource = ctrlv.getAllProducts();
        }

        private void categoriesBindingNavigator_RefreshItems(object sender, EventArgs e)
        {
            if(categoriesBindingSource.Current == null)
            {
                return;
            }
            DataRowView drw = (DataRowView)categoriesBindingSource.Current;
            int cid = (int)drw.Row["CategoryID"];
            productsBindingSource.Filter = "CategoryID = " + cid;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int cantidad = Convert.ToInt32(txtCantidad.Text);
                double precio = double.Parse(unitPriceTextBox.Text);
                double total = ctrlv.calcularTotal(cantidad, precio);
                txtTotal.Text = total.ToString();

                DataRowView drw = (DataRowView)categoriesBindingSource.Current;
                int categoria = (int)drw.Row["CategoryID"];

                double descuento = ctrlv.calcularDescuento(cantidad, total, categoria);
                txtDescuento.Text = Convert.ToString(descuento);

                double neto = ctrlv.calcularNeto(total, descuento);
                txtNeto.Text = Convert.ToString(neto);
            }
            catch
            {
                return;
            }
        }
    }
}
