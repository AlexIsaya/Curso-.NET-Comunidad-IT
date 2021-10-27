using System;
using System.IO;

namespace apertura_archivo
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombreArchivo = "C:\\datos.csv";
            //1
            FileStream stream = new FileStream(nombreArchivo,
                 FileMode.Open
                 ,FileAccess.Read);
            //2
            StreamReader reader = new StreamReader(stream);
            //3
            Console.WriteLine("Leyendo archivo...");
            while (reader.Peek() > -1)
            {
                Console.WriteLine(reader.ReadLine());
            }
            reader.Close();
            Console.WriteLine("Fin de archivo!");
            Console.ReadKey();
        }
    }
}
