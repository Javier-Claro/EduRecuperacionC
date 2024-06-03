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
            int opcion = 9;
            try { 
            Console.WriteLine("\n\t\t0: cierre Menu");
            Console.WriteLine("\n\t\t1: alta Alumno");
            Console.WriteLine("\n\t\t2: baja Alumno");
            Console.WriteLine("\n\t\t3: mostrar Alumnos");
            Console.WriteLine("\n\t\t4: añadir en fichero Alumnos");
            Console.WriteLine("\n\t\t5: modificar Alumno");
            opcion = Convert.ToInt32(Console.ReadLine());                              
            }

            catch(Exception ex)
            {
                Console.WriteLine("\n\tLa opción escogida no existe.");
            }

            return opcion;
        }

        public int MenuModificarAlumno()
        {
            int opcion = 9;
            try { 
            Console.WriteLine("\n\t\t0: cierre Menu");
            Console.WriteLine("\n\t\t1: Nombre");
            Console.WriteLine("\n\t\t2: Apellido 1");
            Console.WriteLine("\n\t\t3: Apellido 2");
            Console.WriteLine("\n\t\t4: Dirección");
            Console.WriteLine("\n\t\t5: Teléfono");
            Console.WriteLine("\n\t\t6: Email");
            Console.WriteLine("\n\t\t7: FechaNacimiento");
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
