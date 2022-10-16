using Proyecto_1_HPA_4.modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_1_HPA_4.DB
{
    class Estudianteinfo
    {
        private List<Estudiante> ListadodeEstudiantes;

        public List<Estudiante> Get()
        {
            if (ListadodeEstudiantes == null)
            {
                ListadodeEstudiantes = new List<Estudiante>();
            }
            return ListadodeEstudiantes;
        }
        public void AgregarEstudiante(Estudiante estudiante)
        {
            ListadodeEstudiantes.Add(estudiante);

        }
    }
}
