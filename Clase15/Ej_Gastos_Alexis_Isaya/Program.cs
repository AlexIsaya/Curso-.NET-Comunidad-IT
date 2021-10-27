using System;

namespace Ej_Gastos_Alexis_Isaya
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dias = new string[7];
            float[] gastos = new float[7];
            float suma = 0, promedio = 0;
            dias[0] = "Lunes";
            dias[1] = "Martes";
            dias[2] = "Miercoles";
            dias[3] = "Jueves";
            dias[4] = "Viernes";
            dias[5] = "Sabado";
            dias[6] = "Domingo";

            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("Ingrese el gasto del dia "+dias[i]+": ");
                gastos[i] = float.Parse(Console.ReadLine());
                suma = suma + gastos[i]; 
            }
            Console.WriteLine("Total de gastos en la semana: $"+suma);
            promedio = suma / gastos.Length;
            Console.WriteLine("Promedio: "+promedio);

            for (int i = 0; i < 7; i++)
            {
                if(gastos[i]>(2*promedio))
                {
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Dia "+dias[i]+": sobrepasó el doble del promedio");
                }
                else
                {
                    Console.ResetColor();
                    Console.WriteLine("Dia "+dias[i]+": normal");
                }
            }
        }
    }
}
