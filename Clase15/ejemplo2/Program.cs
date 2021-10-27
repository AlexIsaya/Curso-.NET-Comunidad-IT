using System;

namespace ejemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Alumno: Alexis Isaya");
            Console.WriteLine("Ejercitación con For y Switch");
            
            for (int i = 0; i <= 7; i++)
            {
                switch (i){
                    case 1:
                        Console.WriteLine("Lunes");
                        break;
                    case 2:
                        Console.WriteLine("Martes");
                        break;
                    case 3:
                        Console.WriteLine("Miercoles");
                        break;
                    case 4:
                        Console.WriteLine("Jueves");
                        break;
                    case 5:
                        Console.WriteLine("Viernes");
                        break;
                    case 6:
                        Console.WriteLine("Sabado");
                        break;
                    case 7:
                        Console.WriteLine("Domingo");
                        break;
                }
            }
            Console.WriteLine();
            Console.WriteLine("...presione una tecla para finalizar");
            Console.ReadKey();
        }
    }
}
