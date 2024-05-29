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
        public static string rutaFicheroLog = string.Concat(rutaCarpetaLogs, Utilidades.crearNombreLog());
        public static string rutaFicheroAlumno = "C:\\Users\\JCB\\Desktop\\patata.txt";
        public static List<AlumnoDto> listaAlumno = new List<AlumnoDto>();

        static void Main(string[] args)
        {
            MenuIntfz men = new MenuImpl();
            FicheroInterfaz fich = new FicheroImplementacion();
            OperativaInterfaz opr = new OperativaImplementacion();
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

                            opr.AñadirAlumno();
                        break;

                    case 2:
                            fich.EscribirFichero(Convert.ToString(opcion));

                            opr.EliminarAlumno();
                            break;
                    
                    case 3:
                        fich.EscribirFichero(Convert.ToString(opcion));

                        opr.mostrarAlumno();
                        break;                    

                    case 4:
                        fich.EscribirFichero(Convert.ToString(opcion));

                            fich.anyadirAlumnosFichero();
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
