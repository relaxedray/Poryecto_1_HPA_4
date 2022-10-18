using Proyecto_1_HPA_4.modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_1_HPA_4.DB
{
    class Estudianteinfo
    {
        public List<Estudiante> ListadodeEstudiantes;

        public Estudianteinfo()
        {
            ListadodeEstudiantes = new List<Estudiante>
            {
                new Estudiante
                {
                    Nombre="Diego Casto",
                    Cedula="1-1234-12345",
                    Fecha=DateTime.Now.ToString()
                },
                new Estudiante
                {
                    Nombre="Pedro Jaramillo",
                    Cedula="1-1234-12346",
                    Fecha=DateTime.Now.ToString()
                }
            };
        }

        public void AgregarEstudiante(Estudiante estudiante)
        {
            ListadodeEstudiantes.Add(estudiante);
        }
    }
}
