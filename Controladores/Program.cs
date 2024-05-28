using System;
using EduRecuperacionC.Util;
using System.ComponentModel.DataAnnotations;
using System.Net.Http.Headers;
using EduRecuperacionC.Dtos;
using EduRecuperacionC.Servicios;

namespace EduRecuperacionC.Controladores
{  
    class Program
    {           
        public static string rutaCarpetaLogs = "C:\\Users\\JCB\\Desktop\\Prog\\Logs\\";
        public static string rutaFicheroLog = string.Concat(rutaCarpetaLogs, Util.Utilidades.crearNombreLog());
        public static List<AlumnoDto> listaAlumno = new List<AlumnoDto>();

        static void Main(string[] args)
        {
            MenuIntfz men = new MenuImpl();
            FicheroInterfaz fich = new FicheroImplementacion();
            bool salirMenu = true;

            do
            {
                try { 
                int opcion = men.Menu();          
                switch(opcion)
                {
                    case 0:
                            fich.EscribirFichero(Convert.ToString(opcion));

                            salirMenu = false;
                        break;

                           
                    case 1:
                            fich.EscribirFichero(Convert.ToString(opcion));

                            Console.WriteLine("Patata");
                        break;
                }
                }
                catch(Exception ex)
                {
                    fich.EscribirFichero("Ha ocurrido un error en el Menu.");;
                }

            } while (salirMenu);
        }
    }
}
