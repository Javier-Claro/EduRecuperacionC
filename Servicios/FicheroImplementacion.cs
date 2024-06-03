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
                using (sw = new StreamWriter(Program.rutaFicheroAlumno))
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

        public void cargarListaAlumno()
        {
            string ruta = Program.rutaFicheroAlumno;

            string[] fichero = File.ReadAllLines(ruta);

            long id = 0;

            foreach (string s in fichero)
            {
                AlumnoDto alm = new AlumnoDto();

                string[] campos = s.Split(';');

                alm.Dni = campos[0];

                alm.Nombre = campos[1];

                alm.IdAlumno = Convert.ToInt32(campos[2]);

                alm.Apellido1 = campos[3];

                alm.Apellido2 = campos[4];

                alm.Direccion = campos[5];

                alm.Telefono = Convert.ToInt32(campos[6]);

                alm.Email = campos[7];

                alm.FechaNacimiento = Convert.ToDateTime(campos[8]);

                Program.listaAlumno.Add(alm);
            }
        }
    }
}
