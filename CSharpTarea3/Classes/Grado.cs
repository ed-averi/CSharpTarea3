using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTarea3.Classes
{
    public  class Grado
    {
        List <Alumno> alumnos = new List <Alumno> ();
        public int Limite { get; set; } = 10;
        public bool Registro (Alumno a)
        {
            if (alumnos.Count == this.Limite)
            {
                throw new GradoException("Ya se alcanzo el numero maximo de alumnos");
            }
            alumnos.Add (a);
            return true;
        }
    }
}
