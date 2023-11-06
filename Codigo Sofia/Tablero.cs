using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candy
{
    public class Tablero    // Creamos la clase tablero

    {
        public int cantidadFil {  get; set; }
        public int cantidadCol { get; set; }    //Caracteristicas de la clase
        public int[,] valores { get; set; }


        public Tablero(int cantidadFil, int cantidadCol, int cantCaramelos)  //Constructor
        {
            this.cantidadFil = cantidadFil;
            this.cantidadCol = cantidadCol;
            this.valores = new int[cantidadFil,cantidadCol];
            iniciarJuego(cantCaramelos);
        }

        private void iniciarJuego(int cantCaramelos)    //Metodo de iniciar juego
        {
            Random rand = new Random(); //Creamos un objeto random

            for (int i = 0; i < valores.GetLength(0); i++)  //GetLenght retorna la cantida de (0) filas y (1) columnas en una matriz o un arreglo multidimencional
            {
                for(int j = 0; j < valores.GetLength(1); j++)
                {
                    valores[i,j] = rand.Next(cantCaramelos);    //Nos genera un numero aleatorio entre 0 y la cantidad de caramelos para cada posicion...
                                                               //...asi podremos asignarle a cada posicion un caramelo aleatorio
                }
            }
        }
    }
     
}
