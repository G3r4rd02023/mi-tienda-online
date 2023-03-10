using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaObjeto
{
    internal class Producto
    {
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }
        public double totalProducto { get; set; }
        public double totalIsv { get; set; }
        public Producto()
        {
            totalIsv = 0;
        }

        public void calculoSubTotal(int p_cantidad, double p_precio)
        {
            Cantidad = p_cantidad;
            Precio = p_precio;

            totalProducto = Cantidad * Precio;
        }

        public void calculoSubTotalconIsv(int p_cantidad, double p_precio)
        {
            Cantidad = p_cantidad;
            Precio = p_precio;
            totalIsv = (Cantidad * Precio) * 0.15;
            totalProducto = (Cantidad * Precio) + totalIsv;
        }
    }
}
