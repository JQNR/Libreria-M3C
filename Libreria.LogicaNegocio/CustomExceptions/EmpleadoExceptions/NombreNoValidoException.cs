﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.LogicaNegocio.CustomExceptions.EmpleadoExceptions
{
    public class NombreNoValidoException : Exception
    {
        public NombreNoValidoException(string? message) : base(message)
        {
        }
    }
}
