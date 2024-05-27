using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduRecuperacionC.Util
{
    internal static class Utilidades
    {
        public static string crearNombreLog()
        {
            //**Hacer un que un fichero log tenga de nombre la fecha del día que se haga**:

            //Primero coges la fecha de hoy con DateTime:
            DateTime fechaActual = DateTime.Now;

            //Luego pasas el DateTime a string para luego concatenar el nombre entero del fichero:
            string fecha = fechaActual.ToString("ddMMyy");
            string nombreLog = string.Concat("log-",fecha,".txt");

            return nombreLog;
        }
    }
}
