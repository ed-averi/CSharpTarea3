
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTarea3.Classes
{
    public  class Maestro : Persona 
    {

        public Maestro(): base()
        {

        }

        public Maestro(string nombre, string apellidos, string carne, DateTime fechaNac)
            : base(nombre, apellidos, carne, fechaNac)
        {

        }
        public override bool CreatePassword(string password)
        {
            if (password.Length > 7)
            {
                this.password = password;
                return true;
            }
            return false;
        }

    }
}
