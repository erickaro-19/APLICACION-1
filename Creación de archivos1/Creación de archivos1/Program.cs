using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creación_de_archivos1
{
    class Program
    {
        static void Main(string[] args)
        {
            string R = "s";
            while (R == "s")
            {
                Console.WriteLine("Escribe el nombre del arhivo");
                string archivo = Console.ReadLine();
                StreamWriter ar;
                ar = File.CreateText(archivo + ".txt");
                ar.WriteLine("Archivo Creado");
                ar.Close();

                Console.WriteLine("Quieres crear otro archivo?");
                Console.WriteLine("s/n");
                R = Console.ReadLine();
            }
        }
    }
}
