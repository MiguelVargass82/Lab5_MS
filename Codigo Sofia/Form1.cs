using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Candy
{
    public partial class Form1 : Form
    {
        Tablero tab;    //Iniciamos una variable de clase tablero tablero
        public Form1()
        {
            //Método generado automaticamente
            InitializeComponent();
            //Mi objeto tablero

            tab = new Tablero(8, 8, 6);     //tablero 8x8 de 6 tipos de caramelos
            
        }

        public void pintarTablero()
        {
            //Matriz de tipo imágenes de la misma cantidad de filas y columnas
            PictureBox[,] matPictureBox = new PictureBox[tab.cantidadFil, tab.cantidadCol];
            

            //ASIGNACION DE OBJETOS DE PictureBox llamados PictureAux en la matriz matPictureBox
            int y = 25;
            for (int i = 0; i < tab.cantidadFil; i++)
            {
                int x = 25;
                for (int j = 0; j < tab.cantidadCol; j++)
                {
                    PictureBox pictureAux = new PictureBox(); //Creamos un objeto picturebox

                    pictureAux.Image = seleccionarRecursoCaramelo(tab.valores[i,j]);    // Funcion de mas abajo
                                                                                        // cada objeto tab es un tablero con numeros aleatorios del 0 al numero de caramelos


                    pictureAux.Location = new System.Drawing.Point(x, y);   //Esto determina en que posicion se va a mostrar cada imagen

                    pictureAux.Name = $"pictureBox{i}{j}";  //A ese objeto tipo pictureBox de la matriz de vamos a asignar ese nombre

                    pictureAux.Size = new System.Drawing.Size(50, 50);  //Tamaño de cada imagen

                    pictureAux.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;


                    matPictureBox[i, j] = pictureAux;   //Creamos una matriz de objetos PictureBox de cada pictureAux

                    //Mostrar en form
                    Controls.Add(pictureAux);
                    x += 50;
                }
                y += 50;
            }          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pintarTablero();
        }

        private Image seleccionarRecursoCaramelo(int recurso)
        {
            switch(recurso)     //Lo que hace es asignarle por cada numero una imagen
            {
                case 0:
                    return global::Candy.Properties.Resources._0;
                case 1:
                    return global::Candy.Properties.Resources._1;
                case 2:
                    return global::Candy.Properties.Resources._2;
                case 3:
                    return global::Candy.Properties.Resources._3;
                case 4:
                    return global::Candy.Properties.Resources._4;
                default:
                    return global::Candy.Properties.Resources._5;
            }
        }
    }
}
