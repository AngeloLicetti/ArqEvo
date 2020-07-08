using CapaDeDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CtrlVentas
    {
        public dsCategories getAllCategories()
        {
            DAO cd = new DAO();
            //reglas del negocio

            return cd.getAllCategories();
        }

        public dsProducts getAllProducts()
        {
            DAO cd = new DAO();
            //reglas del negocio

            return cd.getAllProducts();
        }

        public double calcularDescuento(int cantidad, double total, int categoria)
        {
            double descuento = 0;
            if(cantidad < 11)
            {
                descuento = 0;
            }
            else if(cantidad < 51)
            {
                descuento = 0.01;
            }
            else if (cantidad < 101)
            {
                descuento = 0.05;
            }
            else if (cantidad < 1001)
            {
                descuento = 0.07;
            }
            else
            {
                descuento = 0.1;
            }

            if(categoria == 2)
            {
                descuento += 0.05;
            }
            else if(categoria == 5)
            {
                descuento += 0.1;
            }
            else if(categoria == 7)
            {
                descuento += 0.12;
            }

            double aleatorio = new Random().NextDouble();
            if(total > 100000 && aleatorio > 0.5)
            {
                descuento += 0.1;
            }

            return descuento;
        }

        public double calcularTotal(int cantidad, double precio)
        {
            return cantidad * precio;
        }

        public double calcularNeto(double total, double descuento)
        {
            return total * (1 - descuento);
        }
    }
}
