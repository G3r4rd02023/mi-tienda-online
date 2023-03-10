using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2doParcial
{
    internal class JROperacionesVarias
    {
        public DateTime JRFecha;
        public DateTime JRFecha2;
        public double JRNota1;
        public double JRNota2;
        public double JRNota3;
        public double JRNota4;
        public double JRPromedio;
        public string JRcadenatexto;
        public int JRiniciotexto;
        public int JRcantidadtexto;
        public string JRAplicaIsv;


        public JROperacionesVarias()
        {
            JRFecha = new DateTime();
            JRFecha2 = new DateTime();
            JRNota1 = 0;
            JRNota2 = 0;
            JRNota3 = 0;
            JRNota4 = 0;
            JRcadenatexto = "";
            JRiniciotexto = 0;
            JRcantidadtexto = 0;
            JRAplicaIsv = "";
            
        }

        public string JRExtraerTexto()
        {
            Console.Write("Ingrese la cadena de texto");
            JRcadenatexto = Console.ReadLine();
            Console.Write("Ingrese la posicion inicial");
            JRiniciotexto = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la cantidad de texto a extraer");
            JRcantidadtexto = int.Parse(Console.ReadLine());

            return JRcadenatexto.Substring(JRiniciotexto, JRcantidadtexto);

        }

        public string JRRetornarNombreLargoDia(DateTime pJRFecha)
        {
            return pJRFecha.DayOfWeek.ToString();
        }

        public double JRCalcularTotal(double pJRSubTotal)
        {
            Console.Write("Aplica ISV S/N: ");
            JRAplicaIsv = Console .ReadLine();
            if (JRAplicaIsv == "S")
            {
                return pJRSubTotal * 1.15;
            }
            else
            {
                return pJRSubTotal;
            }
        }

        public DateTime JRSumarAños(DateTime pJRFecha, int pJRCantidad)
        {
            return pJRFecha.AddYears(pJRCantidad);
        }

        public string JRConvertirMinúsculas()
        {
            Console.Write("Ingrese la cadena de texto");
            JRcadenatexto = Console.ReadLine();
            return JRcadenatexto.ToLower();
        }

        public int JRCompararDosFechas(DateTime pJRFecha, DateTime pJRFecha2)
        {
            int JRResultado = DateTime.Compare(pJRFecha, pJRFecha2);
            if (JRResultado < 0)
            {
                Console.WriteLine("Fecha uno es menor que fecha dos");
            }
            else if (JRResultado > 0)
            {
                Console.WriteLine("Fecha uno es mayor que fecha dos");
            }
            else
            {
                Console.WriteLine("Fecha uno es IGUAL que fecha dos");
            }
            return JRResultado;
        }

        public double JRCalcularPromedio(double pJRNota1, double pJRNota2,double pJRNota3,double pJRNota4)
        {
            return (pJRNota1 + pJRNota2 + pJRNota3 + pJRNota4) / 4;
        }

        public string JRRetornarEntero(DateTime pJRFecha)
        {
            return pJRFecha.Month.ToString();
        }



    }
}
