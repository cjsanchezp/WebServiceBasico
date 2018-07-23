using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AplicacionWebServicePOO
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.
    public class Service1 : IService1
    {
        public Persona GetPersona(int cedula, string nombre, string apellido, int edad)
        {
            Persona persona1 = new Persona();

            persona1.cedula = cedula;
            persona1.nombre = nombre;
            persona1.apellido = apellido;
            persona1.edad = edad;

            return persona1;
        }
    }
}
