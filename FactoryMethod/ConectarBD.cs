﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class ConectarBD : Conectar
    {
        public override string StringConexion()
        {
            return "Conextar a BD";
        }
    }
}
