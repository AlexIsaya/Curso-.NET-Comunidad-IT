using System;
using Catalogo;

namespace ejemplo1_poo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Primer objeto");

            Producto hamburguesa = new Producto();
            hamburguesa.nombre = "Burguer Argenta";
            Console.WriteLine(hamburguesa.nombre);
            Console.ReadKey();
        }
    }
}
