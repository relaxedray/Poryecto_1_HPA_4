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
                ListadodeEstudiantes = new List<Estudiante>
                {
                    new Estudiante
                    {
                        Nombre="Eric",
                        Cedula="123123",
                        Fecha=DateTime.Now.ToString()
                    }
                };
            }
            return ListadodeEstudiantes;
        }
        public static void AgregarEstudiante(Estudiante estudiante)
        {
            ListadodeEstudiantes.Add(estudiante);
        }
    }
}
