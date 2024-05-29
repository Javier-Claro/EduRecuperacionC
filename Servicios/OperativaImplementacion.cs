using EduRecuperacionC.Dtos;
using EduRecuperacionC.Controladores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduRecuperacionC.Servicios
{
    internal class OperativaImplementacion : OperativaInterfaz
    {
        public void AñadirAlumno()
        {
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

           Program.listaAlumno.Add(nuevoAlumno);
        }


        public void EliminarAlumno()
        {
            Console.Write("Indique el Dni del alumno a eliminar: ");
            string fueraAlumno = Console.ReadLine();

            AlumnoDto alumnoBorrar = new AlumnoDto();

            foreach (AlumnoDto alumno  in Program.listaAlumno)
            {
                if (alumno.Dni.Equals(fueraAlumno))
                {
                    alumnoBorrar = alumno;                    
                }
            }           
            Program.listaAlumno.Remove(alumnoBorrar);
        }

        public void mostrarAlumno()
        {
            foreach (AlumnoDto alumno in Program.listaAlumno)
            {
                Console.WriteLine(alumno.ToString());
            }
        }
    }
}