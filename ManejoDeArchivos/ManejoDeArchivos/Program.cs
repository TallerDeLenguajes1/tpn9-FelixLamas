using Helpers;
using System;
using System.IO;

namespace ManejoDeArchivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombreDelArchivo = "destino";
            SoporteParaConfiguracion.CrearArchivoDeConfiguracion(nombreDelArchivo);
        }
    }
}
namespace Helpers
{
    public static class SoporteParaConfiguracion
    {
        public static void CrearArchivoDeConfiguracion (string nombre)
        {
            if (!File.Exists(nombre))
            {
                FileStream detino = new FileStream(nombre, FileMode.Create);
            }
            else
            {
                Console.WriteLine("el archivo existe");
            }
        }
        
}
