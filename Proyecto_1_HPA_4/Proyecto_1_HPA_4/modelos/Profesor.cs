using System;
namespace Proyecto_1_HPA_4.modelos
{
    public class Profesor
    {
        public String Nombre;
        public String Usuario;
        public String Password;

        public override String ToString()
        {
            return $"{Nombre}:{Usuario}:{Password.GetHashCode()}";
        }
    }
}

