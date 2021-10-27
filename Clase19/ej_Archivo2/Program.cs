using System;
using System.IO;

namespace ej_Archivo2
{
    class Program
    {
        static void Main(string[] args)
        {
            

            try
            {
                string pDescri;
                string pUrl;
                Console.WriteLine("Ingrese descripcion");
                pDescri = Console.ReadLine();
                Console.WriteLine("Ingrese URL");
                pUrl = Console.ReadLine();
                
                bool existe = false; //se crea varaible Bool para hacer condicion a fin de generar o no el archivo
                string ruta= "C:\\agenda_web2.csv"; // variable que guarda la ubicacion del archivo, no olvidar la barra doble y al final el nombre del archivo
                existe = File.Exists(ruta); // se consulta si la ruta existe, en este caso devuelve el valor true
                
                if(existe) 
                {
                    Console.WriteLine("Si existe");
                    StreamWriter objetoEscritura = File.AppendText(ruta); 
                    objetoEscritura.WriteLine("google;https://google.com.ar");
                    objetoEscritura.WriteLine(pDescri + ";" + pUrl);

                    objetoEscritura.Close(); //Instruccion para cerrar archivo y q se pueda escribir
                    Console.WriteLine("Escritura correcta");
                }
                else
                {
                    Console.WriteLine("No existe, hay que Crear el Archivo");
                }
            }
            catch (System.IO.IOException e1)
            {
                
                Console.WriteLine("Error al intentar abrir el archivo. Descripcion: " +e1.Message);
            }
            catch (System.Exception e2) //excepcion general, debe ir al ultimo de todas las exceptions
            {
                
                Console.WriteLine("Error desconpcido. Descripcion: " +e2.Message);
            }
        }
    }
}
