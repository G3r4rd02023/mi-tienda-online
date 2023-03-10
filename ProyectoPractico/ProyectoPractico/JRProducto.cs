namespace ProyectoPractico
{
    internal class JRProducto
    {
        private int _JRNoProducto;
        private string _JRNombre;
        private double _JRPrecioUnitario;
        private string _JRAplicaIsv;
        private double _JRISV;
        private int _JRCantidadMax;
        private double _JRCosto;
        private string _JRTipoUnidad;
        private int _JRUndxCaja;
        private string _JRTipoVenta;

        public int JRNoProducto { get => _JRNoProducto; set => _JRNoProducto = value; }
        public string JRNombre { get => _JRNombre; set => _JRNombre = value; }
        public double JRPrecioUnitario { get => _JRPrecioUnitario; set => _JRPrecioUnitario = value; }
        public string JRAplicaIsv { get => _JRAplicaIsv; set => _JRAplicaIsv = value; }
        public double JRISV { get => _JRISV; set => _JRISV = value; }
        public int JRCantidadMax { get => _JRCantidadMax; set => _JRCantidadMax = value; }
        public double JRCosto { get => _JRCosto; set => _JRCosto = value; }
        public string JRTipoUnidad { get => _JRTipoUnidad; set => _JRTipoUnidad = value; }
        public int JRUndxCaja { get => _JRUndxCaja; set => _JRUndxCaja = value; }
        public string JRTipoVenta { get => _JRTipoVenta; set => _JRTipoVenta = value; }

        public void ListaProducto()//Listar todos los clientes
        {
            List<JRProducto> jRProducto = new List<JRProducto>
            {
                new JRProducto{ JRNoProducto = 0, JRNombre = "---------------------------",JRPrecioUnitario = 0,
                    JRAplicaIsv = "N",JRISV = 0.15,JRCantidadMax = 100,JRCosto = 0, JRTipoUnidad = "",
                    JRUndxCaja = 0,JRTipoVenta = ""},
                new JRProducto{ JRNoProducto = 1, JRNombre = "Coca-Cola Lata",JRPrecioUnitario = 15,
                    JRAplicaIsv = "S",JRISV = 0.15,JRCantidadMax = 10,JRCosto = 10, JRTipoUnidad = "Lata",
                    JRUndxCaja = 24,JRTipoVenta = "Caja/Unidad"},
                new JRProducto{ JRNoProducto = 2, JRNombre = "Pepsi Lata",JRPrecioUnitario = 16,
                    JRAplicaIsv = "S",JRISV = 0.15,JRCantidadMax = 10,JRCosto = 10, JRTipoUnidad = "Lata",
                    JRUndxCaja = 24,JRTipoVenta = "Caja/Unidad"},
                new JRProducto{ JRNoProducto = 3, JRNombre = "Sprite Lata",JRPrecioUnitario = 15,
                    JRAplicaIsv = "S",JRISV = 0.15,JRCantidadMax = 10,JRCosto = 10, JRTipoUnidad = "Lata",
                    JRUndxCaja = 24,JRTipoVenta = "Caja/Unidad"},
                new JRProducto{ JRNoProducto = 4, JRNombre = "Mirinda Lata",JRPrecioUnitario = 15,
                    JRAplicaIsv = "S",JRISV = 0.15,JRCantidadMax = 10,JRCosto = 10, JRTipoUnidad = "Lata",
                    JRUndxCaja = 24,JRTipoVenta = "Caja/Unidad"},
                new JRProducto{ JRNoProducto = 5, JRNombre = "Jugo Naturas Lata",JRPrecioUnitario = 12,
                    JRAplicaIsv = "S",JRISV = 0.15,JRCantidadMax = 10,JRCosto = 8, JRTipoUnidad = "Lata",
                    JRUndxCaja = 24,JRTipoVenta = "Caja/Unidad"},
                new JRProducto{ JRNoProducto = 6, JRNombre = "Jugo del Valle Lata",JRPrecioUnitario = 10,
                    JRAplicaIsv = "S",JRISV = 0.15,JRCantidadMax = 10,JRCosto = 5, JRTipoUnidad = "Lata",
                    JRUndxCaja = 24,JRTipoVenta = "Caja/Unidad"},
                new JRProducto{ JRNoProducto = 7, JRNombre = "Jugo California Lata",JRPrecioUnitario = 18,
                    JRAplicaIsv = "S",JRISV = 0.15,JRCantidadMax = 10,JRCosto = 12, JRTipoUnidad = "Lata",
                    JRUndxCaja = 24,JRTipoVenta = "Caja/Unidad"},
                new JRProducto{ JRNoProducto = 8, JRNombre = "Acti-Malta Lata",JRPrecioUnitario = 20,
                    JRAplicaIsv = "S",JRISV = 0.15,JRCantidadMax = 10,JRCosto = 12, JRTipoUnidad = "Lata",
                    JRUndxCaja = 24,JRTipoVenta = "Caja/Unidad"},
                new JRProducto{ JRNoProducto = 9, JRNombre = "Raptor Lata",JRPrecioUnitario = 20,
                    JRAplicaIsv = "S",JRISV = 0.15,JRCantidadMax = 10,JRCosto = 12, JRTipoUnidad = "Lata",
                    JRUndxCaja = 24,JRTipoVenta = "Caja/Unidad"},
                new JRProducto{ JRNoProducto = 10, JRNombre = "Energizer Lata",JRPrecioUnitario = 25,
                    JRAplicaIsv = "S",JRISV = 0.15,JRCantidadMax = 10,JRCosto = 15, JRTipoUnidad = "Lata",
                    JRUndxCaja = 24,JRTipoVenta = "Caja/Unidad"},
                new JRProducto{ JRNoProducto = 11, JRNombre = "Adrenalina Lata",JRPrecioUnitario = 20,
                    JRAplicaIsv = "S",JRISV = 0.15,JRCantidadMax = 10,JRCosto = 12, JRTipoUnidad = "Lata",
                    JRUndxCaja = 24,JRTipoVenta = "Caja/Unidad"},
                new JRProducto{ JRNoProducto = 12, JRNombre = "Té Lipton Lata",JRPrecioUnitario = 10,
                    JRAplicaIsv = "S",JRISV = 0.15,JRCantidadMax = 10,JRCosto = 5, JRTipoUnidad = "Lata",
                    JRUndxCaja = 24,JRTipoVenta = "Caja/Unidad"},
                new JRProducto{ JRNoProducto = 13, JRNombre = "Gatorade Lata",JRPrecioUnitario = 25,
                    JRAplicaIsv = "S",JRISV = 0.15,JRCantidadMax = 10,JRCosto = 15, JRTipoUnidad = "Lata",
                    JRUndxCaja = 24,JRTipoVenta = "Caja/Unidad"},
                new JRProducto{ JRNoProducto = 14, JRNombre = "Powerade Lata",JRPrecioUnitario = 22,
                    JRAplicaIsv = "S",JRISV = 0.15,JRCantidadMax = 10,JRCosto = 11, JRTipoUnidad = "Lata",
                    JRUndxCaja = 24,JRTipoVenta = "Caja/Unidad"},
                new JRProducto{ JRNoProducto = 15, JRNombre = "Red Bull Lata",JRPrecioUnitario = 30,
                    JRAplicaIsv = "S",JRISV = 0.15,JRCantidadMax = 10,JRCosto = 18, JRTipoUnidad = "Lata",
                    JRUndxCaja = 24,JRTipoVenta = "Caja/Unidad"},
            };
            for (int RegProducto = 1; RegProducto < jRProducto.Count; RegProducto++)
            {
                Console.WriteLine("Producto: " + RegProducto + " ." + jRProducto[RegProducto].JRNombre);
            }

        }

        private void SeleccionProducto(int Pindice)//Seleccionar un producto según su índice...
        {
            List<JRProducto> jRProducto = new List<JRProducto>
            {
                new JRProducto{ JRNoProducto = 0, JRNombre = "---------------------------",JRPrecioUnitario = 0,
                    JRAplicaIsv = "N",JRISV = 0.15,JRCantidadMax = 100,JRCosto = 0, JRTipoUnidad = "",
                    JRUndxCaja = 0,JRTipoVenta = ""},
                new JRProducto{ JRNoProducto = 1, JRNombre = "Coca-Cola Lata",JRPrecioUnitario = 15,
                    JRAplicaIsv = "S",JRISV = 0.15,JRCantidadMax = 10,JRCosto = 10, JRTipoUnidad = "Lata",
                    JRUndxCaja = 24,JRTipoVenta = "Caja/Unidad"},
                new JRProducto{ JRNoProducto = 2, JRNombre = "Pepsi Lata",JRPrecioUnitario = 16,
                    JRAplicaIsv = "S",JRISV = 0.15,JRCantidadMax = 10,JRCosto = 10, JRTipoUnidad = "Lata",
                    JRUndxCaja = 24,JRTipoVenta = "Caja/Unidad"},
                new JRProducto{ JRNoProducto = 3, JRNombre = "Sprite Lata",JRPrecioUnitario = 15,
                    JRAplicaIsv = "S",JRISV = 0.15,JRCantidadMax = 10,JRCosto = 10, JRTipoUnidad = "Lata",
                    JRUndxCaja = 24,JRTipoVenta = "Caja/Unidad"},
                new JRProducto{ JRNoProducto = 4, JRNombre = "Mirinda Lata",JRPrecioUnitario = 15,
                    JRAplicaIsv = "S",JRISV = 0.15,JRCantidadMax = 10,JRCosto = 10, JRTipoUnidad = "Lata",
                    JRUndxCaja = 24,JRTipoVenta = "Caja/Unidad"},
                new JRProducto{ JRNoProducto = 5, JRNombre = "Jugo Naturas Lata",JRPrecioUnitario = 12,
                    JRAplicaIsv = "S",JRISV = 0.15,JRCantidadMax = 10,JRCosto = 8, JRTipoUnidad = "Lata",
                    JRUndxCaja = 24,JRTipoVenta = "Caja/Unidad"},
                new JRProducto{ JRNoProducto = 6, JRNombre = "Jugo del Valle Lata",JRPrecioUnitario = 10,
                    JRAplicaIsv = "S",JRISV = 0.15,JRCantidadMax = 10,JRCosto = 5, JRTipoUnidad = "Lata",
                    JRUndxCaja = 24,JRTipoVenta = "Caja/Unidad"},
                new JRProducto{ JRNoProducto = 7, JRNombre = "Jugo California Lata",JRPrecioUnitario = 18,
                    JRAplicaIsv = "S",JRISV = 0.15,JRCantidadMax = 10,JRCosto = 12, JRTipoUnidad = "Lata",
                    JRUndxCaja = 24,JRTipoVenta = "Caja/Unidad"},
                new JRProducto{ JRNoProducto = 8, JRNombre = "Acti-Malta Lata",JRPrecioUnitario = 20,
                    JRAplicaIsv = "S",JRISV = 0.15,JRCantidadMax = 10,JRCosto = 12, JRTipoUnidad = "Lata",
                    JRUndxCaja = 24,JRTipoVenta = "Caja/Unidad"},
                new JRProducto{ JRNoProducto = 9, JRNombre = "Raptor Lata",JRPrecioUnitario = 20,
                    JRAplicaIsv = "S",JRISV = 0.15,JRCantidadMax = 10,JRCosto = 12, JRTipoUnidad = "Lata",
                    JRUndxCaja = 24,JRTipoVenta = "Caja/Unidad"},
                new JRProducto{ JRNoProducto = 10, JRNombre = "Energizer Lata",JRPrecioUnitario = 25,
                    JRAplicaIsv = "S",JRISV = 0.15,JRCantidadMax = 10,JRCosto = 15, JRTipoUnidad = "Lata",
                    JRUndxCaja = 24,JRTipoVenta = "Caja/Unidad"},
                new JRProducto{ JRNoProducto = 11, JRNombre = "Adrenalina Lata",JRPrecioUnitario = 20,
                    JRAplicaIsv = "S",JRISV = 0.15,JRCantidadMax = 10,JRCosto = 12, JRTipoUnidad = "Lata",
                    JRUndxCaja = 24,JRTipoVenta = "Caja/Unidad"},
                new JRProducto{ JRNoProducto = 12, JRNombre = "Té Lipton Lata",JRPrecioUnitario = 10,
                    JRAplicaIsv = "S",JRISV = 0.15,JRCantidadMax = 10,JRCosto = 5, JRTipoUnidad = "Lata",
                    JRUndxCaja = 24,JRTipoVenta = "Caja/Unidad"},
                new JRProducto{ JRNoProducto = 13, JRNombre = "Gatorade Lata",JRPrecioUnitario = 25,
                    JRAplicaIsv = "S",JRISV = 0.15,JRCantidadMax = 10,JRCosto = 15, JRTipoUnidad = "Lata",
                    JRUndxCaja = 24,JRTipoVenta = "Caja/Unidad"},
                new JRProducto{ JRNoProducto = 14, JRNombre = "Powerade Lata",JRPrecioUnitario = 22,
                    JRAplicaIsv = "S",JRISV = 0.15,JRCantidadMax = 10,JRCosto = 11, JRTipoUnidad = "Lata",
                    JRUndxCaja = 24,JRTipoVenta = "Caja/Unidad"},
                new JRProducto{ JRNoProducto = 15, JRNombre = "Red Bull Lata",JRPrecioUnitario = 30,
                    JRAplicaIsv = "S",JRISV = 0.15,JRCantidadMax = 10,JRCosto = 18, JRTipoUnidad = "Lata",
                    JRUndxCaja = 24,JRTipoVenta = "Caja/Unidad"},
            };
            Console.Clear();
            Console.WriteLine("No.Producto: " + jRProducto[Pindice].JRNoProducto + "_" +
                jRProducto[Pindice].JRNombre);
            Console.WriteLine("Con Precio Unitario: " + jRProducto[Pindice].JRPrecioUnitario);
        }
    }
}
