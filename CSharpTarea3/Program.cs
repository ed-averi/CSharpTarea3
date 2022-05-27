using System;
using CSharpTarea3.Classes;

namespace CSharpTarea3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AgregarAlumnos();
        }

        public static void AgregarAlumnos()
        {
            Grado gr = new Grado();
            gr.Registro(new Alumno("Juan", "Gamez", "100001", DateTime.Parse("2000-01-01")));
        }
    }
}
