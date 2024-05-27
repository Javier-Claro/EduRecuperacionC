using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduRecuperacionC.Servicios
{
    internal class FicheroImplementacion : FicheroInterfaz
    {
        public void EscribirFichero(string texto)
        {
            StreamWriter sw = new StreamWriter(Controladores.Program.rutaFicheroLog, true);
            sw.WriteLine(texto);
            sw.Close();
        }
    }
}
