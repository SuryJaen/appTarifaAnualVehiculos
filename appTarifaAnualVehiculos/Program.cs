using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appTarifaAnualVehiculos
{
    class Program
    {
        static void Main(string[] args)
        {
            int tarifa = 0;
            Console.WriteLine("===============================");
            Console.WriteLine("=======CONTROL DE INPUESTOS====");
            Console.WriteLine("===========VEHICULARES=========");
            Console.WriteLine("");
            Console.WriteLine("SELECCIONE EL TIPO DE VEHICULO");
            Console.WriteLine("1. VEHICULO LIVIANO");
            Console.WriteLine("2. VEHICULO PESADO");
            String digito = Console.ReadLine();
            int opcion = int.Parse(digito);

            if (opcion == 1)
                tarifa = 3;
            else
                tarifa = 5;

            //switch(opcion)
            //{
            //    case 1:
            //        tarifa = 3;
            //        break;
            //    case 2:
            //        tarifa = 5;
            //        break;
            //}
            Console.WriteLine("DEBES PAGAR UNA TARIFA DE {0} % ANUAL", tarifa);
            Console.ReadLine();
            Console.Clear();
            return;

        }
    }
}
