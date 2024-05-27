using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduRecuperacionC.Servicios
{
    internal class MenuImpl :MenuIntfz
    {
        public int Menu()
        {
            int opcion;

            Console.WriteLine("\n\t\t0: cierre Menu");
            Console.WriteLine("\n\t\t1: alta Objeto");
            opcion = Convert.ToInt32(Console.ReadLine());

            return opcion;
        }
    }
}
