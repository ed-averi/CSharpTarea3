
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTarea3.Classes
{
    public class Alumno  : Persona
    {

        public Alumno()
        {

        }

        public Alumno(string nombre, string apellidos, string carne, DateTime fechaNac)
            : base(nombre, apellidos, carne, fechaNac)
        {

        }

        public override bool CreatePassword(string password)
        {
            if (password.Length > 3 && password.Length<=8)
            {
                this.password = password;
                return true;
            }
            return false;
        }
    }
}
