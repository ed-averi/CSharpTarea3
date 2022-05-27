using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTarea3.Classes
{
    public abstract class Persona
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Carne { get; set; }
        public DateTime FechaNacimiento { get; set; }

        protected string password;
        private string nombre;
        private DateTime fechaNac;

        protected Persona(string nombre, string apellidos, string carne, DateTime fechaNac)
        {
            this.nombre = nombre;
            Apellidos = apellidos;
            Carne = carne;
            this.fechaNac = fechaNac;
        }

        protected Persona()
        {
        }

        public virtual bool CreatePassword(string password)
        {
            this.password = password;
            return true;

        }
    }
}
