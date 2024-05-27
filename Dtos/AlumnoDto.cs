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

        //int id = 0;
        string nombre = "aaaaa";
        string apellido1 = "aaaaa";
        string apellido2 = "aaaaa";
        string dni = "aaaaa";
        string direccion = "aaaaa";
        int telefono = 366464;
        string email = "aaaaa";

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido1 { get => apellido1; set => apellido1 = value; }
        public string Apellido2 { get => apellido2; set => apellido2 = value; }
        public string Dni { get => dni; set => dni = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }
    }
}
