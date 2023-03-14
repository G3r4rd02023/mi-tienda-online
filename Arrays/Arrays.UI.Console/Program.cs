using Arrays.Logic;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hello, Arrays!");
                int option;
                var myArray = new Vector(10);
                myArray.Fill();
                do
                {
                    option = Menu();
                    switch (option)
                    {
                        case 1:
                            Console.Write("Ingrese número de elementos: ");
                            var nString = Console.ReadLine();
                            int n = 10;
                            int.TryParse(nString, out n);
                            myArray = new Vector(n);
                            myArray.Fill();
                            break;
                        case 2:
                            Console.WriteLine(myArray);
                            break;
                        case 3:
                            Console.WriteLine(myArray.GetOdds());
                            break;
                        case 4:
                            Console.WriteLine(myArray.GetPrimes());
                            break;
                        case 5:
                            Console.WriteLine(myArray.GetNonRepeated());
                            break;
                        case 6:
                            Console.WriteLine(myArray.GetMostRepeated());
                            break;
                        default:
                            Console.WriteLine("Fuck you. Opción no existe!!!!");
                            break;
                    }
                } while (option != 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static int Menu()
        {
            Console.WriteLine("1. Definir tamaño de arreglo");
            Console.WriteLine("2. Mostrar arreglo");
            Console.WriteLine("3. Mostrar múmeros pares");
            Console.WriteLine("4. Mostrar múmeros primos");
            Console.WriteLine("5. Mostrar múmeros que no se repiten");
            Console.WriteLine("6. Mostrar múmeros que más se repiten");
            Console.WriteLine("0. Salir");
            bool isValid = false;
            int option = 0;
            do
            {
                Console.Write("Digite su opción: ");
                var optionString = Console.ReadLine();
                if (!int.TryParse(optionString, out option))
                {
                    Console.WriteLine("Opción inválida, solo use números.");
                    isValid = false;
                }
                else
                {
                    isValid = true;
                }
            } while (!isValid);
            return option;
        }
    }
}