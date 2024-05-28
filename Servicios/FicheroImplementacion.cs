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
                using (sw = new StreamWriter(Controladores.Program.rutaFicheroLog, true)){ 

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
    }
}
