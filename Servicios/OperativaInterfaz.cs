using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EduRecuperacionC.Dtos;

namespace EduRecuperacionC.Servicios
{
    internal interface OperativaInterfaz
    {
        public void AñadirAlumno();

        public void EliminarAlumno();

        public void mostrarAlumno();

        public void ModificarAlumno(int opcion);
    }
}
