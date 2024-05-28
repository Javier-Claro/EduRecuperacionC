using EduRecuperacionC.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EduRecuperacionC.Dtos;

namespace EduRecuperacionC.Servicios
{
    internal class OperativaImplementacion : OperativaInterfaz
    {
        public void AñadirAlumno()
        {
            try { }
            catch (Exception ex) { }
            finally { }
            AlumnoDto nuevoAlumno = new AlumnoDto();

            Console.Write("\n\tIndique su nombre: ");
            nuevoAlumno.Nombre = Console.ReadLine();

            Console.Write("\n\tIndique su primer apellido: ");
            nuevoAlumno.Apellido1 = Console.ReadLine();

            Console.Write("\n\tIndique su segundo apellido: ");
            nuevoAlumno.Apellido2 = Console.ReadLine();

            Console.Write("\n\tIndique su dni: ");
            nuevoAlumno.Dni = Console.ReadLine();

            Console.Write("\n\tIndique su dirección: ");
            nuevoAlumno.Direccion = Console.ReadLine();

            Console.Write("\n\tIndique su teléfono: ");
            nuevoAlumno.Telefono = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n\tIndique su email: ");
            nuevoAlumno.Email = Console.ReadLine();

            Controladores.Program.listaAlumno.Add(nuevoAlumno);
        }

    }
}
