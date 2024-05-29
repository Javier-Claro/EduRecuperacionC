using EduRecuperacionC.Controladores;
using EduRecuperacionC.Dtos;
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
            StreamWriter sw = null; 
            
            try {
                using (sw = new StreamWriter(Program.rutaFicheroLog, true))
                { 

            sw.WriteLine(texto);
                }           
            }

            catch(Exception ex) {
                Console.WriteLine(ex.ToString());
            }

            finally { 
                if (sw != null)  
                sw.Close();               
            }
        }

        public void anyadirAlumnosFichero()
        {
            StreamWriter sw = null;

            try
            {
                using (sw = new StreamWriter(Program.rutaFicheroAlumno, true))
                {
                    foreach (AlumnoDto alumno in Program.listaAlumno)
                    {
                        sw.Write(alumno.ToString(';'));
                    }
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            finally
            {
                if (sw != null)
                    sw.Close();
            }
        }
    }
}
