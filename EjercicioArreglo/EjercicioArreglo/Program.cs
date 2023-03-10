namespace EjercicioArreglo
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //programa para el registro de alumnos
            int vl_JRTamañoArreglo = 0;
            string vl_JRTamaño = "";           
            double JRSuma = 0, JRPromedio = 0;
            Console.Write("Ingrese el numero de alumnos a registrar : ");
            vl_JRTamañoArreglo = int.Parse(Console.ReadLine());

            //Declaración de los arreglos
            int[] JRNumeroCuenta = new int[vl_JRTamañoArreglo];
            string[] JRNombreAlumno = new string[vl_JRTamañoArreglo];
            double[] JRNotaFinal = new double[vl_JRTamañoArreglo];
            DateTime[] JRFechaMatricula = new DateTime[vl_JRTamañoArreglo];

            //ciclo for para capturar los datos y agregarlos a los arreglos
            for(int i = 0; i < JRNumeroCuenta.Length; i++)
            {
                Console.Write("Ingrese el numero de cuenta del alumno {0}: ", i + 1);
                JRNumeroCuenta[i] = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el nombre del alumno {0}: ", i + 1);
                JRNombreAlumno[i] = Console.ReadLine();
                Console.Write("Ingrese la nota final del alumno {0}: ", i + 1);
                JRNotaFinal[i] = double.Parse(Console.ReadLine());
                Console.Write("Ingrese la fecha de matricula del alumno {0}: ", i + 1);
                JRFechaMatricula[i] = DateTime.Parse(Console.ReadLine());

                Console.Clear();
                
            }

            //ciclo for para determinar si el alumno aprobó o reprobó
            for (int i = 0; i < JRNumeroCuenta.Length; i++)
                {
                Console.WriteLine("Datos del Alumno : {0} .......................", i + 1);
                    if (JRNotaFinal[i] >= 65)
                    {
                    
                        string vl_JRMerito = "aprobó";
                        Console.WriteLine("El alumno : {0} con número de cuenta : {1}" +
                            " {2} la clase con nota {3} fecha de matricula {4} " + 
                            " ", JRNombreAlumno[i], JRNumeroCuenta[i], vl_JRMerito, JRNotaFinal[i], JRFechaMatricula[i]);
                    }
                    else
                    {
                        string vl_JRMerito = "reprobó";
                        Console.WriteLine("EL alumno : {0} con número de cuenta : {1}" +
                            " {2} la clase con nota {3} fecha de matricula {4}" +
                            " ", JRNombreAlumno[i], JRNumeroCuenta[i], vl_JRMerito, JRNotaFinal[i], JRFechaMatricula[i]);
                    }
                }

            //ciclo foreach para calcular el promedio de notas 
            foreach (double nota in JRNotaFinal)
            {
                JRSuma += nota;
            }

            JRPromedio = JRSuma / JRNotaFinal.Length;

            Console.WriteLine("Resumen Final.........................");
            Console.WriteLine("El Promedio de notas es: " + JRPromedio);
            Console.WriteLine("La Cantidad de alumnos ingresados es: " + JRNotaFinal.Length);



        }

        
    }
}