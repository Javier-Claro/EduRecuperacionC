using EduRecuperacionC.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EduRecuperacionC.Dtos;
using EduRecuperacionC.Controladores;
using System.Collections;

namespace EduRecuperacionC.Util
{
    internal static class Utilidades
    {
        public static string crearNombreLog()
        {
            //**Hacer un que un fichero log tenga de nombre la fecha del día que se haga**:
            string nombreLog = "";
            
            try { 
            //Primero coges la fecha de hoy con DateTime:
            DateTime fechaActual = DateTime.Now;
           
            //Luego pasas el DateTime a string para luego concatenar el nombre entero del fichero:
            string fecha = fechaActual.ToString("ddMMyy");
            nombreLog = string.Concat("log-",fecha,".txt");           
            }
            catch(Exception ex)
            {
                Console.WriteLine("Ha ocurrido un error al escribir el nombre del archivo.");
            }
            return nombreLog;
        }

        public static List<AlumnoDto> idAutogeneradoAlumno()
        {
            List<AlumnoDto> nuevaListaAlumno = Program.listaAlumno;

            int tamanyoLista = nuevaListaAlumno.Count;
            long nuevaId;
            if (tamanyoLista > 0)
            {
                nuevaId = nuevaListaAlumno[tamanyoLista - 1].IdAlumno + 1;
            }
            else
            {
                nuevaId = 1;
            }

            return nuevaListaAlumno;
        }
    }
}
