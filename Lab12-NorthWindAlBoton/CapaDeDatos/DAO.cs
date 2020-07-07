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
        public dsCategories getAllCategories()
        {
            //DataSet dsc = new dsCategories();
            //dsCategoriesTableAdapters.CategoriesTableAdapter cta = new dsCategoriesTableAdapters.CategoriesTableAdapter();
            //cta.Fill(dsc.Categories);
            //return dsc;

            var dsc = new dsCategories();
            var cta = new dsCategoriesTableAdapters.CategoriesTableAdapter();
            cta.Fill(dsc.Categories);
            return dsc;
        }

        public dsProducts getAllProducts()
        {
            var dsp = new dsProducts();
            var pta = new dsProductsTableAdapters.ProductsTableAdapter();
            pta.Fill(dsp.Products);
            return dsp;
        }
    }
}
