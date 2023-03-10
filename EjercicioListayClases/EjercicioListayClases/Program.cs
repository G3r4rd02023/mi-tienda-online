namespace EjercicioListayClases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string lv_JRseguir = "S",lv_JRNombreAlumno = "";
            double lv_JRn1 = 0, lv_JRn2 = 0, lv_JRn3 = 0, lv_JRnotaFinal = 0,lv_JRProm = 0,lv_JRSumaNotas = 0;
            int lv_JRnumCuenta = 0,lv_JRNumOpcion = 0,lv_JRCantAlumnos = 0;

            Alumno ObjAlumno = new Alumno();
            List<Alumno> JRlistaAlumno = new List<Alumno>();

            while (lv_JRseguir == "S")
            {
                Console.WriteLine("Ingrese el numero de cuenta del alumno: ");
                lv_JRnumCuenta = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el nombre del alumno: ");
                lv_JRNombreAlumno = Console.ReadLine();

                Console.WriteLine("Ingrese Nota I Parcial: ");
                lv_JRn1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese Nota II Parcial: ");
                lv_JRn2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese Nota III Parcial: ");
                lv_JRn3 = double.Parse(Console.ReadLine());

                ObjAlumno.calculoNotaFinal(lv_JRn1,lv_JRn2,lv_JRn3);

                lv_JRnotaFinal = ObjAlumno.NotaFinal;

                JRlistaAlumno.Add(new Alumno
                {
                    NombreAlumno = lv_JRNombreAlumno,
                    NumeroCuenta = lv_JRnumCuenta,
                    NotaIParcial = lv_JRn1,
                    NotaIIParcial = lv_JRn2,
                    NotaIIIParcial = lv_JRn3,
                    NotaFinal = lv_JRnotaFinal
                });

                Console.WriteLine("Desea ingresar otro alumno? : ");
                lv_JRseguir = Console.ReadLine().ToUpper();

                Console.Clear();
            }

            Console.WriteLine("Opciones de Resultado.......");
            Console.WriteLine("1. Ver Resultado Detallado..");
            Console.WriteLine("2. Ver Resultados en Resumen");
            Console.WriteLine("3. Ver Detalle y Resumen ...");

            Console.WriteLine("Ingrese el Número de Opción.");
            lv_JRNumOpcion = int.Parse(Console.ReadLine());

            if(lv_JRNumOpcion == 1)
            {
                Console.WriteLine("...............Detalle de Alumnos..............");
                foreach (Alumno item in JRlistaAlumno)
                {                   
                    Console.WriteLine("El Alumno es: {0} con cuenta {1} con índice {2}... ", item.NombreAlumno, item.NumeroCuenta,item.NotaFinal);                    
                }
            }
            else if (lv_JRNumOpcion == 2)
            {
                Console.WriteLine("...............Resumen de la Clase..............");
                foreach (Alumno item in JRlistaAlumno)
                {
                    lv_JRCantAlumnos++;
                    lv_JRSumaNotas += item.NotaFinal;
                    lv_JRProm = lv_JRSumaNotas / lv_JRCantAlumnos;
                    
                }
                Console.WriteLine("La cantidad de Alumnos : {0} el promedio general : {1} ", lv_JRCantAlumnos, lv_JRProm);
            }
            else if(lv_JRNumOpcion == 3)
            {
                Console.WriteLine("...............Detalle de Alumnos..............");
                foreach (Alumno item in JRlistaAlumno)
                {                   
                    Console.WriteLine("El Alumno es: {0} con cuenta {1} con índice {2}... ", item.NombreAlumno, item.NumeroCuenta, item.NotaFinal);                    
                    lv_JRCantAlumnos++;
                    lv_JRSumaNotas += item.NotaFinal;
                    lv_JRProm = lv_JRSumaNotas / lv_JRCantAlumnos;                    
                }
                Console.WriteLine("...............Resumen de la Clase..............");
                Console.WriteLine("La cantidad de Alumnos : {0} el promedio general : {1} ", lv_JRCantAlumnos, lv_JRProm);
            }           
        }
    }
}