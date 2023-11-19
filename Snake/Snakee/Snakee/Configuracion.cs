using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snakee
{
    //en esta clase creamos las propiedades que tendra la serpiente, que tan grande se verá en el picturebox...
    //...y le asignamos la direccion en la cual se empezará a mover
    internal class Configuracion
    {
        public static int ancho {  get; set; }
        public static int alto { get; set; }
        public static string direcciones { get; set;}

        //Fijamos los valores en los cuales estará el tamaño de la serpiente...
  
        public Configuracion()
        {
            //el tamaño de los cuadritos de la serpiente al igual que de la cuadricula
            ancho = 20;
            alto = 20;
            direcciones = "derecha";

        }
    }
}
