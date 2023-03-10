using System.Collections.Generic;

namespace ProyectoPractico
{
    internal class JRCliente
    {
        private int _JRCodigoCliente;
        private string _JRNombre;
        private string _JRDirección;
        private string _JRTeléfono;
        private string _JREmail;
        private string _JRRTN;
        private int _JRDíasCrédito;
        private string _JRAplicaDescuento;
        private double _JRDescuento;
        private string _JRTerceraEdad;
        private string _JRCelular;

        public int JRCodigoCliente { get => _JRCodigoCliente; set => _JRCodigoCliente = value; }
        public string JRNombre { get => _JRNombre; set => _JRNombre = value; }
        public string JRDirección { get => _JRDirección; set => _JRDirección = value; }
        public string JRTeléfono { get => _JRTeléfono; set => _JRTeléfono = value; }
        public string JREmail { get => _JREmail; set => _JREmail = value; }
        public string JRRTN { get => _JRRTN; set => _JRRTN = value; }
        public int JRDíasCrédito { get => _JRDíasCrédito; set => _JRDíasCrédito = value; }
        public string JRAplicaDescuento { get => _JRAplicaDescuento; set => _JRAplicaDescuento = value; }
        public double JRDescuento { get => _JRDescuento; set => _JRDescuento = value; }
        public string JRTerceraEdad { get => _JRTerceraEdad; set => _JRTerceraEdad = value; }
        public string JRCelular { get => _JRCelular; set => _JRCelular = value; }

       public void ListaCliente()//Listar todos los clientes
        {
            List<JRCliente> jRClientes= new List<JRCliente>
            { 
                new JRCliente{ JRCodigoCliente = 0, JRNombre = "---------------------------",JRDirección = "",
                    JRTeléfono = "",JREmail ="",JRRTN = "",JRDíasCrédito = 0, JRAplicaDescuento = "N", 
                    JRDescuento = 0,JRTerceraEdad = "N", JRCelular = ""},
                new JRCliente{ JRCodigoCliente = 1, JRNombre = "José Rodriguez",JRDirección = "Res.Francisco Morazán",
                    JRTeléfono = "2218-4435",JREmail ="jrodriguez@gmail.com",JRRTN = "08011989102901",JRDíasCrédito = 30, JRAplicaDescuento = "S",
                    JRDescuento = 0.05,JRTerceraEdad = "N", JRCelular = "3308-9209"},
                new JRCliente{ JRCodigoCliente = 2, JRNombre = "Gustavo Flores",JRDirección = "Res.Bella Vista",
                    JRTeléfono = "2245-0910",JREmail ="gflores@gmail.com",JRRTN = "08011989203196",JRDíasCrédito = 60, JRAplicaDescuento = "S",
                    JRDescuento = 0.05,JRTerceraEdad = "N", JRCelular = "3306-9285"},
                new JRCliente{ JRCodigoCliente = 3, JRNombre = "Roger Torres",JRDirección = "Col.Las Palmas",
                    JRTeléfono = "2246-0192",JREmail ="rtorres@gmail.com",JRRTN = "08011950132601",JRDíasCrédito = 90, JRAplicaDescuento = "S",
                    JRDescuento = 0.10,JRTerceraEdad = "S", JRCelular = "3307-9251"},
                new JRCliente{ JRCodigoCliente = 4, JRNombre = "Franklin Flores",JRDirección = "Res.Villas de Concepción",
                    JRTeléfono = "2688-4430",JREmail ="fflores@gmail.com",JRRTN = "08011979100921",JRDíasCrédito = 30, JRAplicaDescuento = "S",
                    JRDescuento = 0.05,JRTerceraEdad = "N", JRCelular = "3308-9889"},
                new JRCliente{ JRCodigoCliente = 5, JRNombre = "Juan Pineda",JRDirección = "Res.Tres Caminos",
                    JRTeléfono = "9818-0674",JREmail ="jpineda@gmail.com",JRRTN = "080119992901",JRDíasCrédito = 30, JRAplicaDescuento = "S",
                    JRDescuento = 0.05,JRTerceraEdad = "N", JRCelular = "3308-9289"},
                new JRCliente{ JRCodigoCliente = 6, JRNombre = "Santos Ponce",JRDirección = "Colonia Ulloa",
                    JRTeléfono = "9818-4433",JREmail ="sponce@gmail.com",JRRTN = "08011981102341",JRDíasCrédito = 30, JRAplicaDescuento = "N",
                    JRDescuento = 0,JRTerceraEdad = "N", JRCelular = "3308-7205"},
                new JRCliente{ JRCodigoCliente = 7, JRNombre = "Margarita Aguilera",JRDirección = "Res.San José",
                    JRTeléfono = "9818-4335",JREmail ="maguilar@gmail.com",JRRTN = "08101979102701",JRDíasCrédito = 30, JRAplicaDescuento = "S",
                    JRDescuento = 0.05,JRTerceraEdad = "N", JRCelular = "3308-9200"},
                new JRCliente{ JRCodigoCliente = 8, JRNombre = "Angela Dávila",JRDirección = "Res.Bella Oriente",
                    JRTeléfono = "9818-4480",JREmail ="adavila@gmail.com",JRRTN = "08111992102231",JRDíasCrédito = 60, JRAplicaDescuento = "S",
                    JRDescuento = 0.05,JRTerceraEdad = "N", JRCelular = "3308-9209"},
                new JRCliente{ JRCodigoCliente = 9, JRNombre = "Ramón Barrientos",JRDirección = "Res.Quezada",
                    JRTeléfono = "9818-4435",JREmail ="rbarrientos@gmail.com",JRRTN = "08011982102901",JRDíasCrédito = 60, JRAplicaDescuento = "S",
                    JRDescuento = 0.05,JRTerceraEdad = "N", JRCelular = "3358-9209"},
                new JRCliente{ JRCodigoCliente = 10, JRNombre = "Ericka Zambrano",JRDirección = "Res.Los Angeles",
                    JRTeléfono = "9818-8201",JREmail ="ezambrano@gmail.com",JRRTN = "08111980102981",JRDíasCrédito = 30, JRAplicaDescuento = "S",
                    JRDescuento = 0.05,JRTerceraEdad = "N", JRCelular = "3358_9209"}
            };
            for (int RegCliente = 1; RegCliente < jRClientes.Count; RegCliente++)
            {
                Console.WriteLine("Cliente: " + RegCliente + " ." + jRClientes[RegCliente].JRNombre);
            }
        }

        private void SeleccionCliente(int Pindice)//Seleccionar un cliente según su índice...
        {
            List<JRCliente> jRClientes = new List<JRCliente>
            {
                new JRCliente
                {
                    JRCodigoCliente = 0,
                    JRNombre = "---------------------------",
                    JRDirección = "",
                    JRTeléfono = "",
                    JREmail = "",
                    JRRTN = "",
                    JRDíasCrédito = 0,
                    JRAplicaDescuento = "N",
                    JRDescuento = 0,
                    JRTerceraEdad = "N",
                    JRCelular = ""
                },
                new JRCliente
                {
                    JRCodigoCliente = 1,
                    JRNombre = "José Rodriguez",
                    JRDirección = "Res.Francisco Morazán",
                    JRTeléfono = "2218-4435",
                    JREmail = "jrodriguez@gmail.com",
                    JRRTN = "08011989102901",
                    JRDíasCrédito = 30,
                    JRAplicaDescuento = "S",
                    JRDescuento = 0.05,
                    JRTerceraEdad = "N",
                    JRCelular = "3308-9209"
                },
                new JRCliente
                {
                    JRCodigoCliente = 2,
                    JRNombre = "Gustavo Flores",
                    JRDirección = "Res.Bella Vista",
                    JRTeléfono = "2245-0910",
                    JREmail = "gflores@gmail.com",
                    JRRTN = "08011989203196",
                    JRDíasCrédito = 60,
                    JRAplicaDescuento = "S",
                    JRDescuento = 0.05,
                    JRTerceraEdad = "N",
                    JRCelular = "3306-9285"
                },
                new JRCliente
                {
                    JRCodigoCliente = 3,
                    JRNombre = "Roger Torres",
                    JRDirección = "Col.Las Palmas",
                    JRTeléfono = "2246-0192",
                    JREmail = "rtorres@gmail.com",
                    JRRTN = "08011950132601",
                    JRDíasCrédito = 90,
                    JRAplicaDescuento = "S",
                    JRDescuento = 0.10,
                    JRTerceraEdad = "S",
                    JRCelular = "3307-9251"
                },
                new JRCliente
                {
                    JRCodigoCliente = 4,
                    JRNombre = "Franklin Flores",
                    JRDirección = "Res.Villas de Concepción",
                    JRTeléfono = "2688-4430",
                    JREmail = "fflores@gmail.com",
                    JRRTN = "08011979100921",
                    JRDíasCrédito = 30,
                    JRAplicaDescuento = "S",
                    JRDescuento = 0.05,
                    JRTerceraEdad = "N",
                    JRCelular = "3308-9889"
                },
                new JRCliente
                {
                    JRCodigoCliente = 5,
                    JRNombre = "Juan Pineda",
                    JRDirección = "Res.Tres Caminos",
                    JRTeléfono = "9818-0674",
                    JREmail = "jpineda@gmail.com",
                    JRRTN = "080119992901",
                    JRDíasCrédito = 30,
                    JRAplicaDescuento = "S",
                    JRDescuento = 0.05,
                    JRTerceraEdad = "N",
                    JRCelular = "3308-9289"
                },
                new JRCliente
                {
                    JRCodigoCliente = 6,
                    JRNombre = "Santos Ponce",
                    JRDirección = "Colonia Ulloa",
                    JRTeléfono = "9818-4433",
                    JREmail = "sponce@gmail.com",
                    JRRTN = "08011981102341",
                    JRDíasCrédito = 30,
                    JRAplicaDescuento = "N",
                    JRDescuento = 0,
                    JRTerceraEdad = "N",
                    JRCelular = "3308-7205"
                },
                new JRCliente
                {
                    JRCodigoCliente = 7,
                    JRNombre = "Margarita Aguilera",
                    JRDirección = "Res.San José",
                    JRTeléfono = "9818-4335",
                    JREmail = "maguilar@gmail.com",
                    JRRTN = "08101979102701",
                    JRDíasCrédito = 30,
                    JRAplicaDescuento = "S",
                    JRDescuento = 0.05,
                    JRTerceraEdad = "N",
                    JRCelular = "3308-9200"
                },
                new JRCliente
                {
                    JRCodigoCliente = 8,
                    JRNombre = "Angela Dávila",
                    JRDirección = "Res.Bella Oriente",
                    JRTeléfono = "9818-4480",
                    JREmail = "adavila@gmail.com",
                    JRRTN = "08111992102231",
                    JRDíasCrédito = 60,
                    JRAplicaDescuento = "S",
                    JRDescuento = 0.05,
                    JRTerceraEdad = "N",
                    JRCelular = "3308-9209"
                },
                new JRCliente
                {
                    JRCodigoCliente = 9,
                    JRNombre = "Ramón Barrientos",
                    JRDirección = "Res.Quezada",
                    JRTeléfono = "9818-4435",
                    JREmail = "rbarrientos@gmail.com",
                    JRRTN = "08011982102901",
                    JRDíasCrédito = 60,
                    JRAplicaDescuento = "S",
                    JRDescuento = 0.05,
                    JRTerceraEdad = "N",
                    JRCelular = "3358-9209"
                },
                new JRCliente
                {
                    JRCodigoCliente = 10,
                    JRNombre = "Ericka Zambrano",
                    JRDirección = "Res.Los Angeles",
                    JRTeléfono = "9818-8201",
                    JREmail = "ezambrano@gmail.com",
                    JRRTN = "08111980102981",
                    JRDíasCrédito = 30,
                    JRAplicaDescuento = "S",
                    JRDescuento = 0.05,
                    JRTerceraEdad = "N",
                    JRCelular = "3358_9209"
                }
            };
            Console.Clear();
            Console.WriteLine("No.Cliente: " + jRClientes[Pindice].JRCodigoCliente + "_" +
                jRClientes[Pindice].JRNombre);
            Console.WriteLine("Con dirección: " + jRClientes[Pindice].JRDirección);
        }

    }
}

