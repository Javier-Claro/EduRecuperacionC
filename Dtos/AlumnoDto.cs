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

        private long idAlumno;
        private string nombre = "aaaaa";
        private string apellido1 = "aaaaa1";
        private string apellido2 = "aaaaa2";
        private string dni = "aaaaa";
        private string direccion = "aaaaapoyo";
        private int telefono = 0;
        private string email = "aaaaa@";
        private DateTime fechaNacimiento;

        public AlumnoDto(int idAlumno, string nombre, string apellido1, string apellido2, string dni, string direccion, int telefono, string email, DateTime fechaNacimiento)
        {
            this.idAlumno = idAlumno;
            this.nombre = nombre;
            this.apellido1 = apellido1;
            this.apellido2 = apellido2;
            this.dni = dni;
            this.direccion = direccion;
            this.telefono = telefono;
            this.email = email;
            this.fechaNacimiento = fechaNacimiento;
        }
        public AlumnoDto() { }

        public long IdAlumno { get => idAlumno; set => idAlumno = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido1 { get => apellido1; set => apellido1 = value; }
        public string Apellido2 { get => apellido2; set => apellido2 = value; }
        public string Dni { get => dni; set => dni = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento= value; }


        override
        public string ToString()
        {
            string registroAlumno = string.Concat(this.dni, " - ", this.nombre, " - ", this.idAlumno, " - ",  
                this.apellido1, " - ", this.apellido2, " - ", this.direccion, " - ", 
                this.telefono, " - ", this.email, " - ", this.fechaNacimiento);

            return registroAlumno;
        }

        public string ToString(char puntoComa)
        {
            string listadoFichero = string.Concat(this.dni, puntoComa, this.nombre, puntoComa, this.idAlumno, puntoComa,
                this.apellido1, puntoComa, this.apellido2, puntoComa, this.direccion, puntoComa,
                this.telefono, puntoComa, this.email, puntoComa, this.fechaNacimiento);

            return listadoFichero;
        }
    }   
}
