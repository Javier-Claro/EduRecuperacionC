using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduRecuperacionC.Dtos
{
    internal class AlumnoDto
    {
        //"nombre, apll1, apll2, dni, direcc, tlf, email"

        int idAlumno = 000;
        string nombre = "aaaaa";
        string apellido1 = "aaaaa";
        string apellido2 = "aaaaa";
        string dni = "aaaaa";
        string direccion = "aaaaa";
        int telefono = 366464;
        string email = "aaaaa";

        public AlumnoDto(int idAlumno, string nombre, string apellido1, string apellido2, string dni, string direccion, int telefono, string email)
        {
            this.idAlumno = idAlumno;
            this.nombre = nombre;
            this.apellido1 = apellido1;
            this.apellido2 = apellido2;
            this.dni = dni;
            this.direccion = direccion;
            this.telefono = telefono;
            this.email = email;
        }
        public AlumnoDto() { }

        public int IdAlumno { get => idAlumno; set => idAlumno = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido1 { get => apellido1; set => apellido1 = value; }
        public string Apellido2 { get => apellido2; set => apellido2 = value; }
        public string Dni { get => dni; set => dni = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }


        override
        public string ToString()
        {
            string registroAlumno = string.Concat(this.dni, " - ", this.nombre);

            return registroAlumno;
        }

        public string ToString(char puntoComa)
        {
            string listadoFichero = string.Concat(this.dni, puntoComa, this.nombre, "\n");

            return listadoFichero;
        }
    }   
}
