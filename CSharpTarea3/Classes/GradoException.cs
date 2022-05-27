﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTarea3.Classes
{
    public class GradoException : Exception
    {
        public GradoException() : base()
            { }
        public GradoException(string mensaje): base(mensaje)
            { }
        public GradoException(string mensaje, Exception ex): base (mensaje, ex)
            { }
    }
}
