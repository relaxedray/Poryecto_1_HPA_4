using Proyecto_1_HPA_4.modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_1_HPA_4.DB
{
    class Estudianteinfo
    {
        public static List<Estudiante> ListadodeEstudiantes;
        public static List<Estudiante> ObtenerEstudiantes()
        {
            if(ListadodeEstudiantes == null)
            {
                ListadodeEstudiantes = new List<Estudiante>();
            }
            return ListadodeEstudiantes;
        }
        public static void AgregarEstudiante(Estudiante estudiante)
        {
            ObtenerEstudiantes().Add(estudiante);
        }
    }
}
