using System;
using System.Diagnostics;

namespace visitar_pagina
{
    class Program
    {
        static void Main(string[] args)
        {
            string directorio = "C:\\Users\\ISAYA\\AppData\\Roaming\\Spotify";
            var procesoExterno= new ProcessStartInfo(directorio)
                {
                    Arguments = "",
                    UseShellExecute = true,
                    //en la ruta va doble barra
                    WorkingDirectory = directorio,
                    FileName = "Spotify.exe",
                    Verb = "OPEN"
                };
            Process.Start(procesoExterno);
        }
    }
}
