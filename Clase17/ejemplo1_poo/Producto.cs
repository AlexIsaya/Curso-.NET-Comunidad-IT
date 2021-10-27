using System;

namespace Catalogo
{
    public class Producto
    {
        //ATRIBUTOS
        private string Nombre;
        private string descripcion;
        private float precio;
        private string foto;
        private int stock;
        
        //Constructor

        public string nombre {get;set;}
    /*    public string Nombre
        {
        //return. que devuelve
            get => nombre; //devuelve variable nombre
        //Establecer
            set
            {
                //value;
                nombre = value;
            }
        }*/
        public string Descripcion
        {
            get => descripcion; // variable
            set
            {
                descripcion=value;
            }
        }
        //METODO
        string Mostrar()
        {
            return Nombre + " se compone de " + Descripcion;
        }
    }
}