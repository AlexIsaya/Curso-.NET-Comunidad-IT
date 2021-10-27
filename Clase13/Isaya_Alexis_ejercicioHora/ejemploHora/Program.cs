using System;

namespace ejemploHora
{
    class Program
    {
        static void Main(string[] args)
        {
            string dia = "";
            int hora = 0;

            Console.WriteLine("Ingresar el dia que es hoy: ");
            dia = Console.ReadLine();  
            
            while (dia == "lunes" || dia == "miercoles" || dia == "viernes")  
            {
                Console.WriteLine("Ingresar la hora: ");
                hora = int.Parse(Console.ReadLine());            
                if (hora == 9)
                {
                    Console.WriteLine("Prender PC y entrar al Gmeeting");
                    break;
                }
                else if (hora >= 10 && hora <= 12)
                {
                    Console.WriteLine("Ya estamos en clase! ");
                    break;
                }
                else if (hora > 12 || hora < 9)
                {
                    Console.WriteLine("No es hora de entrar a clases");
                    break;
                }
            }
            if(dia == "jueves" || dia == "martes"){
                Console.WriteLine("Hoy no hay clases");
            } 
            else if(dia == "sabado" || dia == "domingo"){
                Console.WriteLine("Es fin de semana!");
            }
            
        }
    }
}
