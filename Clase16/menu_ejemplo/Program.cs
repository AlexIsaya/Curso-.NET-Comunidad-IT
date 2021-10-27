using System;

namespace menu_ejemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcionUsuario = "";

            do{
                Console.Clear();
                ImprimirMenu();
                opcionUsuario = Console.ReadLine();

                switch(opcionUsuario)
                {
                    case "1":
                        agendarPagina();
                        break;
                    case "2":
                        buscar_Direccion();
                        break;
                    case "3":
                        buscar_Url();
                        break;
                    case "4":
                        visitar();
                        break;
                    case "0":
                        Console.WriteLine("saliendo...");
                        break;

                    default:
                        Console.WriteLine("opcion incorrecta");
                        Console.ReadKey();
                        ImprimirMenu();
                        break;
                }

            }while(opcionUsuario != "0");

            Console.ReadKey();
        }

        static void ImprimirMenu(){
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("1-Agendar");
            Console.WriteLine("2-Buscar si existe pagina (por descripcion)");
            Console.WriteLine("3-Buscar si existe pagina (por url)");
            Console.WriteLine("4-Abrir pagina en navegador");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("0-Salir");
            Console.WriteLine("ingrese una opcion");
        }

        static void agendarPagina()
        {
            Console.WriteLine("agendar pagina");
            Console.ReadKey();
        }
        static void buscar_Direccion()
        {
            Console.WriteLine("Buscar si existe pagina (por descripcion)");
            Console.ReadKey();
        }
        static void buscar_Url()
        {
            Console.WriteLine("Buscar si existe pagina (por url)");
            Console.ReadKey();
        }
        static void visitar()
        {
            Console.WriteLine("Abrir pagina en navegador");
            Console.ReadKey();
        }
    }
}
