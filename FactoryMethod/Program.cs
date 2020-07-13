using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Conectar objConexion = Constructor.Crear(1);
            Console.WriteLine(objConexion.StringConexion());
        }
    }
}
