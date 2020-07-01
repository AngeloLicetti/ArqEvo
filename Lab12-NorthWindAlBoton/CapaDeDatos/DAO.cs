using CapaDeDatos.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
    public class DAO
    {
        public DataSet getAllCategories()
        {
            DataSet dsc = new dsCategories();
            dsCategoriesTableAdapters.CategoriesTableAdapter cta = new dsCategoriesTableAdapters.CategoriesTableAdapter();
            //cta.Fill(dsc.Categories);
            return dsc;
        }

        public DataSet getAllProducts()
        {
            DataSet dsc = new dsProducts();
            dsProductsTableAdapters.ProductsTableAdapter cta = new dsProductsTableAdapters.ProductsTableAdapter();
            //cta.Fill(dsc.Products);
            return dsc;
        }
    }
}
