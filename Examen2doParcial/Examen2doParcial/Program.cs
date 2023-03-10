namespace Examen2doParcial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string JRseguir = "S";
            string[] JRMenú = { 
            "1.Extraer parte de un texto",
            "2.Retornar el nombre largode día de semana de una fecha ingresada",
            "3.Calcular el total para una factura",
            "4.Permitir sumar o restar años a una fecha ingresada y mostrar la fecha nueva",
            "5.Convertir a minusculas un texto",
            "6.Comparar dos fechas e indicar al usuario cúal de las dos es menor,mayor o iguales",
            "7.Calcular el promedio del alumno",
            "8.Retornar como entero el número del mes de una fecha ingresada"
            };
                
            int JRopción = 0,JRCantidad = 0;
            DateTime JRFecha1,JRFecha2;
            double JRNota1 = 0, JRNota2 = 0, JRNota3 = 0, JRNota4 = 0; 

            while (JRseguir == "S" || JRseguir == "s")
            {
                foreach (string item in JRMenú)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine("Ingrese el numero de opcion correspondiente ");
                JRopción = int.Parse(Console.ReadLine());

                //seccion de eleccion

                JROperacionesVarias objOperacionesVarias = new JROperacionesVarias();
                switch (JRopción)
                {
                    case 1:
                        Console.WriteLine("El texto extraido : {0}",
                            objOperacionesVarias.JRExtraerTexto());
                        break;
                    case 2:
                        Console.Write("Ingrese la fecha");
                        Console.WriteLine("El nombre largo de día es : {0}",
                             objOperacionesVarias.JRRetornarNombreLargoDia(DateTime.Parse(Console.ReadLine())));
                        break;
                    case 3:
                        Console.Write("Ingrese el SubTotal");
                        Console.WriteLine("El total de la factura es : {0}",
                            objOperacionesVarias.JRCalcularTotal(double.Parse(Console.ReadLine())));
                        break;
                    case 4:
                        Console.Write("Ingrese la fecha");
                        JRFecha1 = DateTime.Parse(Console.ReadLine());
                        Console.Write("Ingrese la cantidad de dias");
                        JRCantidad = int.Parse(Console.ReadLine());
                        Console.WriteLine("La nueva fecha es  : {0}",
                        objOperacionesVarias.JRSumarAños(JRFecha1, JRCantidad));
                        break;
                    case 5:
                        Console.WriteLine("Texto en Minusculas : {0}",
                            objOperacionesVarias.JRConvertirMinúsculas());
                        break;
                    case 6:
                        Console.Write("Ingrese la fecha 1:");
                        JRFecha1 = DateTime.Parse(Console.ReadLine());
                        Console.Write("Ingrese la fecha2");
                        JRFecha2 = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine("El resultado es : {0}",
                             objOperacionesVarias.JRCompararDosFechas(JRFecha1, JRFecha2));
                        break;
                   case 7:
                        Console.Write("Ingrese Nota 1:");
                        JRNota1 = double.Parse(Console.ReadLine());
                        Console.Write("Ingrese Nota 2:");
                        JRNota2 = double.Parse(Console.ReadLine());
                        Console.Write("Ingrese Nota 3:");
                        JRNota3 = double.Parse(Console.ReadLine());
                        Console.Write("Ingrese Nota 4:");
                        JRNota4 = double.Parse(Console.ReadLine());
                        Console.WriteLine("El promedio es : {0}",
                        objOperacionesVarias.JRCalcularPromedio(JRNota1, JRNota2,JRNota3,JRNota4));
                        break;
                   case 8:
                        Console.Write("Ingrese la fecha");
                        Console.WriteLine("El entero es : {0}",
                             objOperacionesVarias.JRRetornarEntero(DateTime.Parse(Console.ReadLine())));
                        break;
                    default:

                        Console.WriteLine("No se ha seleccionado una opcion valida");
                        break;
                }
                
                Console.WriteLine("Desea Continuar con otra opcion S/N:");
                JRseguir = Console.ReadLine();
                Console.Clear();
            }
            
        }
    }
}