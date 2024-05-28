using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduRecuperacionC.Servicios
{
    internal class MenuImpl : MenuIntfz
    {
        public int Menu()
        {
            int opcion = 7;
            try { 
            Console.WriteLine("\n\t\t0: cierre Menu");
            Console.WriteLine("\n\t\t1: alta Objeto");
            opcion = Convert.ToInt32(Console.ReadLine());
                              
            }

            catch(Exception ex)
            {
                Console.WriteLine("\n\tLa opción escogida no existe.");
            }

            return opcion;
        }
    }
}
