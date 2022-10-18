using System;
using System.Collections.Generic;
using Proyecto_1_HPA_4.modelos;
namespace Proyecto_1_HPA_4.DB
{
    public class ProfesoresInfo
    {
        private static List<Profesor> ListadoProfesores = new List<Profesor>
        {
            new Profesor
            {
                Nombre="Juan Zamora",
                Usuario="jzamora",
                Password="asumecha"
            }
        };
        public static Profesor ExisteElProfesor(String usuario, String password)
        {
            return ListadoProfesores.Find(prof =>
                prof.Password.Equals(password)
                && prof.Usuario.Equals(usuario));
        }
    }
}

