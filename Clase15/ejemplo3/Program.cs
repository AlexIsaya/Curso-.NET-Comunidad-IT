using System;

namespace ejemplo3
{
    class Program
    {
        static int funcionPotencia(int x,int potencia)
        {
            int i, p=1;
            for (i = 1; i <= potencia; i++)
            {
                p = p * x;
            }
            return p;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Alumno: Alexis Isaya - Ejercicios Funciones");
            int num, pot,val;
            Console.WriteLine("Ingrese Numero");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Potencia");
            pot = int.Parse(Console.ReadLine());
            val = funcionPotencia(num, pot);
            Console.WriteLine("La potencia de "+num+" elevado a "+pot+" es: ");
            Console.WriteLine(val);
            Console.WriteLine("...presione una tecla para finalizar");
            Console.ReadKey();
        }
    }
}
