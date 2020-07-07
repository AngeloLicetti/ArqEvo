using CapaDeDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    class Category
    {
        public dsCategories getAllCategories()
        {
            DAO cd = new DAO();

            return cd.getAllCategories();
        }
    }
}
