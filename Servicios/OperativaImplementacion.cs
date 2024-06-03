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

            Console.Write("\n\tIndique su fecha de nacimiento: ");
            nuevoAlumno.FechaNacimiento = Convert.ToDateTime(Console.ReadLine());

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

        public void ModificarAlumno(int opcion)
        {
            Console.Write("Indique el Dni del alumno a modificar: ");
            string modAlumno = Console.ReadLine();

            AlumnoDto modificarAlumno = new AlumnoDto();

            foreach (AlumnoDto alumno in Program.listaAlumno)
            {
                if (alumno.Dni.Equals(modAlumno))
                {
                    modificarAlumno = alumno;

                    switch(opcion)
                    {
                        case 1:
                            Console.Write("Indique el nuevo nombre: ");
                            modificarAlumno.Nombre = Console.ReadLine();
                            break;

                        case 2:
                            Console.Write("\n\tIndique su primer apellido: ");
                            modificarAlumno.Apellido1 = Console.ReadLine();
                            break;

                        case 3:
                            Console.Write("\n\tIndique su segundo apellido: ");
                            modificarAlumno.Apellido2 = Console.ReadLine();
                            break;

                        case 4:
                            Console.Write("\n\tIndique su dirección: ");
                            modificarAlumno.Direccion = Console.ReadLine();
                            break;

                        case 5:
                            Console.Write("\n\tIndique su teléfono: ");
                            modificarAlumno.Telefono = Convert.ToInt32(Console.ReadLine());
                            break;

                        case 6:
                            Console.Write("\n\tIndique su email: ");
                            modificarAlumno.Email = Console.ReadLine();
                            break;

                        case 7:
                            Console.Write("\n\tIndique su fecha de nacimiento: ");
                            modificarAlumno.FechaNacimiento = Convert.ToDateTime(Console.ReadLine());
                            break;
                    }

                    Program.listaAlumno.Add(modificarAlumno);
                }
            }
        }
    }
}