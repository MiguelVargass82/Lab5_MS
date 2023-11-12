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
        Button[,] matrizBotones;

        int[,] matrizPosiciones = new int[5,2];    //Matriz grande de maximo 5 coordenadas para verificar, cada coordenada x es un par



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

           





            //-----NOTAS DE MIGUEL--------
            //Si queremos acceder a la matriz de numeros entonces vamos usar tab.valores y a la matriz de imagenes vamos a usar MatPictureBox

            //Dos funciones (1) Tres en linea horizontal y tres en linea vertical 
            //Podriamos usar incluso que las ileras que se borren agarramos las cordenadas en x que serian fijas y asignariamos...
            //...los valores en "y" 1 inmediatamente si el 3 en linea fue horizontal y 3 si fue verticcal, ahora los valores vacios de arriba...
            //..les asignamos un valor aleatorio

            //Tendriamos una matriz fija de 8x8, donde usariamos 64 botones cada uno asignado a una coodenada, la cual se encargara de evaluar arriba, abajo, izquierda, derecha




        }




        private void button1_Click(object sender, EventArgs e)
        {
            pintarTablero();      
        }




        private Image seleccionarRecursoCaramelo(int recurso)   //Retorna imagenes
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


     

        private void f0c1_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("si sirve pa");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int filas = 8; // Número de filas en la matriz
            int columnas = 8; // Número de columnas en la matriz

            // Inicializa la matriz de botones
            matrizBotones = new Button[filas, columnas];

            // Configura el TableLayoutPanel
            matrizBform.RowCount = filas;
            matrizBform.ColumnCount = columnas;

            // Llena la matriz de botones y agrégala al TableLayoutPanel
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    //Logica para la asignacion de las imagenes a los botones

                    Button btn = new Button();      //Creamos un boton que sera parte de la matriz
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.Size = new Size(45, 45);
                    btn.BackColor = Color.Transparent;
                    btn.Text = $"Boton {i }-{j}";
                    int caramelo = tab.valores[i, j];   //Sacamos el numero de la matriz de numeros que pertenece a la posicion del boton

                    btn.Tag = new Tuple<int, int>(i, j);    //En la propiedad tag del boton alcamacena las coordenadas

                    btn.BackgroundImage = seleccionarRecursoCaramelo(caramelo); //Le asociamos una imagen al boton

                    btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;

                    matrizBotones[i, j] = btn;  //metemos en boton en la matriz

                    // Asocia un evento al botón si es necesario
                   // btn.Click += Boton_Click;
                    btn.Click += (senderBtn, eBtn) => Boton_Click(senderBtn, eBtn, i, j);
                    // Agrega el botón al TableLayoutPanel
                    matrizBform.Controls.Add(btn, j, i);
                }
            }
        }

        int numbtn = 0; //Numero de botones a verificar

        int PosicionX = 0;
        int PosicionY = 0;  //Posicion X y Y  para la matriz de coordenadas
        private void Boton_Click(object sender, EventArgs e, int fila, int columna)    //Evento de cualquier boton de la matriz
        {

                         
            if (sender is Button clickedButton)
            {
             

                

              //  MessageBox.Show($"Se hizo clic en el botón en la fila {filaa + 1}, columna {columnaa + 1}.");

                if (numbtn < 5)  
                {
                    // Obtiene la posición desde el Tag del botón
                    Tuple<int, int> posicion = (Tuple<int, int>)clickedButton.Tag;
                    int filaa = posicion.Item1;
                    int columnaa = posicion.Item2;      //En la variable filaaa y columnaaa se almacenan las coordenadas




                    matrizPosiciones[numbtn, 0] = filaa;      //Asignacion de coordenadas en la matriz de posiciones
                    matrizPosiciones[numbtn, 1] = columnaa;

                    numbtn = numbtn + 1;
                }
                
                else  //Caso en que los botones seleccionados sean menor a 3 o mayor a 5
                {
                   
                  
                        MessageBox.Show("No puede haber mas de 5 caramelos seleccionados");
                                  
                }


            }
        }


        private void VerificarButtom_Click(object sender, EventArgs e)  //Evento de BOTON VERIFICAR
        {
            int[] vectorNumeros = new int[numbtn];      //Este vector almacena todos los numeros de las coordenadas seleccionadas para comparar si son iguales yv er si hay 3 en linea

            for (int i =0; i<numbtn; i++)   //Este ciclo se encaragara de comporbar que las coordenadas en en tablero de numeros sean las mismas
            {           
                    int coordenadax = matrizPosiciones[i, 0];
                    int coordenaday = matrizPosiciones[i, 1];

                vectorNumeros[i] = tab.valores[coordenadax,coordenaday];

                //  MessageBox.Show($"coordenada X y Y del boton seleccionado son {coordenadax} y {coordenaday}"); verificador de que ya recolectamos las coordenadas



                MessageBox.Show($"En la matriz de numeros es {vectorNumeros[i]}");
            }






            numbtn=0;   //Volvemos cero este contador para que vuelva a contar las varibles

   //         for (int i = 0; i<4; i++)   //La matriz se llena de ceros
     //       {
       //         for (int j = 0; i<1; j++)
         //       {
           //         matrizPosiciones[i,j]= 0;
             //   }
           // }
            
        }





















        //doble click
        private void matrizBform_Paint(object sender, PaintEventArgs e)
        {

        }
        // doble click en el forms xd
        private void button3_Click(object sender, EventArgs e)
        {
            //buttom 3 es f0c1
        }

     
    }
}
