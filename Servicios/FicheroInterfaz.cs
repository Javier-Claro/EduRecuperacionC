using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduRecuperacionC.Servicios
{
    internal interface FicheroInterfaz
    {
        public void EscribirFichero(string texto);

        public void anyadirAlumnosFichero();

        public void cargarListaAlumno();
    }
}
