using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class Constructor
    {
        public const int TIPO_SQL = 1;
        public const int TIPO_EXCEL = 2;
        public static Conectar Crear(int tipo)
        {
            switch(tipo)
            {
                case TIPO_SQL: return new ConectarBD();
                case TIPO_EXCEL: return new ConectarExcel();
                default: return null;

            }
        }
    }
}
