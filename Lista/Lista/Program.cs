namespace Lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DEfinicion de una lista tipo string
            string lv_seguir = "S";
            List<string> Alumnos = new List<string>();
            List<DateTime> Fechas = new List<DateTime>();
            List<string> Asignatura = new List<string>();

            while (lv_seguir == "S")
            {
                Console.WriteLine("Ingrese el nombre del alumno: ");
                Alumnos.Add(Console.ReadLine());
                Console.WriteLine("Ingrese la asignatura del alumno: ");
                Asignatura.Add(Console.ReadLine());
                Console.WriteLine("Ingrese la fecha de matricula del alumno: ");
                Fechas.Add(DateTime.Parse(Console.ReadLine()));
                Console.WriteLine("Desea Ingresar otro alumno? : ");
                lv_seguir = Console.ReadLine().ToUpper();
            }

            Console.WriteLine(".........Lista de Alumnos......... ");
            
            for(int i = 0; i < Alumnos.Count; i++)
            {
                Console.WriteLine("Nombre de Alumno:{0}, Matriculó la asignatura {1}" +
                    " en la Fecha {2}", Alumnos[i], Asignatura[i],Fechas[i].ToString("D"));
            }

        }
    }
}