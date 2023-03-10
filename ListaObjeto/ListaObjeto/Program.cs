namespace ListaObjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string lv_seguir = "S",lv_descripcion="",lv_aplicaIsv="";
            int lv_cantidad = 0;
            double lv_precio = 0, lv_subtotalproducto = 0,lv_totalfactura = 0,lv_totalIsv = 0, lv_subIsv = 0;

            Producto ObjProducto = new Producto();
            List<Producto> ListaProducto = new List<Producto>();

            while (lv_seguir == "S")
            {
                Console.WriteLine("Ingrese el nombre del producto: ");
                lv_descripcion= Console.ReadLine();
                Console.WriteLine("Ingrese la cantidad del producto: ");
                lv_cantidad= int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el precio del producto: ");
                lv_precio = double.Parse(Console.ReadLine());
                Console.WriteLine("Aplica Isv el producto S/N?: ");
                lv_aplicaIsv = Console.ReadLine().ToUpper();

                if(lv_aplicaIsv == "S")
                {
                    ObjProducto.calculoSubTotalconIsv(lv_cantidad, lv_precio);
                }
                else
                {
                    ObjProducto.calculoSubTotal(lv_cantidad, lv_precio);
                }
                
                lv_subtotalproducto = ObjProducto.totalProducto;
                lv_subIsv = ObjProducto.totalIsv;

                ListaProducto.Add(new Producto
                {
                    Descripcion = lv_descripcion,
                    Cantidad = lv_cantidad,
                    Precio = lv_precio,
                    totalProducto = lv_subtotalproducto,
                    totalIsv = lv_subIsv
                });
                Console.WriteLine("Desea ingresar otro producto? : ");
                lv_seguir = Console.ReadLine().ToUpper();
            }
            
            foreach(Producto item in ListaProducto)
            {
                Console.WriteLine("Descripción {0} con total del producto L.{1}", item.Descripcion, item.totalProducto);
                lv_totalfactura += item.totalProducto;
                lv_totalIsv += item.totalIsv;

            }
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Total Isv la factura es L.{0} ", lv_totalIsv);
            Console.WriteLine("Total de la factura es L.{0} ",lv_totalfactura);

        }
    }
}