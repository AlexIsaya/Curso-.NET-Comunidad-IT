using System;

namespace cenaAmigos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Division de Cena de Amigos");
            float costoComida = 0;
            float costoPostre = 0;
            float costoAlcohol = 0;
            float subtotalPersona = 0;
            float subtotalAlcoholico = 0;
            int cantidadAmigos = 0;
            int cantidadAlcoholicos = 0;
            float total = 0;

            Console.WriteLine("Ingresar la cantidad de Amigos");
            cantidadAmigos = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Ingresar la cantidad de Alcoholicos");
            cantidadAlcoholicos = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Ingresar el costo de comida");
            costoComida = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Ingresar el costo de postre");
            costoPostre = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Ingresar el costo de bebida alcoholica");
            costoAlcohol = float.Parse(Console.ReadLine());

            subtotalPersona = (costoComida + costoPostre)/cantidadAmigos;
            subtotalAlcoholico = costoAlcohol/cantidadAlcoholicos;
            total = costoComida + costoPostre + costoAlcohol;

            if(cantidadAmigos >= 10){
                Console.WriteLine("Debido a que son más de 10 comensales se aplica un descuento del 15%!");
                subtotalPersona = (subtotalPersona*85)/100;
                subtotalAlcoholico = (subtotalAlcoholico*85)/100;
                total = (total*85)/100;
                Console.WriteLine("El subtotal por cada persona no alcohólica es: " + subtotalPersona);
                Console.WriteLine("El subtotal por cada alcohólico es: " + (subtotalPersona+subtotalAlcoholico));
                Console.WriteLine("El total de toda la cena es: " + total);
            }
            else{
                Console.WriteLine("El subtotal por cada persona no alcohólica es: " + subtotalPersona);
                Console.WriteLine("El subtotal por cada alcohólico es: " + (subtotalPersona+subtotalAlcoholico));
                Console.WriteLine("El total de toda la cena es: " + total);
            }

        }
    }
}
