﻿
using Libreria.DTOs.DTOs.DTOsUsuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.LogicaAplicacion.ICasosUso.ICUEmpleado
{
    public interface ICUAltaUsuario
    {
        void AltaEmpleado(DTOAltaUsuario dto);
    }
}
