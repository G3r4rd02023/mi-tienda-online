using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioListayClases
{
    internal class Alumno
    {
        public int NumeroCuenta { get; set; }
        public string NombreAlumno { get; set; }
        public double NotaIParcial { get; set; }
        public double NotaIIParcial { get; set; }
        public double NotaIIIParcial { get; set; }
        public double NotaFinal { get; set; }

        public Alumno()
        {
            NumeroCuenta = 0;
            NombreAlumno = "";
            NotaIParcial = 0;
            NotaIIParcial = 0;
            NotaIIIParcial= 0;
            NotaFinal = 0;
        }

        public void calculoNotaFinal(double p_n1, double p_n2, double p_n3)
        {
            NotaIParcial = p_n1;
            NotaIIParcial = p_n2;
            NotaIIIParcial = p_n3;

            NotaFinal = (NotaIParcial + NotaIIParcial + NotaIIIParcial) / 3;
        }



    }
}
