using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace Snakee
{
    public partial class Form1 : Form
    {

        private List<circle> snake = new List<circle>();
        private circle food = new circle();

        //creamos las variables que corresponden a los bordes de la cuadricula que estará dentro del picturebox
        int maxAncho;
        int maxAlto;

        int score;
        int highScore;
        
        //llamamos un objeto random para definir luego la posicion de la manzana
        Random rand = new Random();

        //Variables para el movimiento segun las teclas presionadas
        bool goleft, goRight , goDown , goUp;
        public Form1()
        {
            InitializeComponent();
            new Configuracion();
          

        }



        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //En los siguientes if se comprueba si se puede realizar dicho movimiento
            //considerando que la serpiente no puede cambiar arriba-abajo, derecha-izquierda sin dar una vuelta antes
            if (e.KeyCode == Keys.Left && Configuracion.direcciones != "derecha")
            {
                goleft = true;

            }
            if (e.KeyCode == Keys.Right && Configuracion.direcciones != "izquierda")
            {
                goRight = true;

            }
            if (e.KeyCode == Keys.Up && Configuracion.direcciones != "abajo")
            {
                goUp = true;

            }
            if (e.KeyCode == Keys.Down && Configuracion.direcciones != "arriba")
            {
                goDown = true;

            }

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            //este es el evento cuando el jugador suelte una tecla, automaticamente dicha orden de moverse en un sentido se termina
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;

            }
            if (e.KeyCode == Keys.Right )
            {
                goRight = false;

            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;

            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;

            }
        }
        
        //button1 hace referencia al boton de iniciar el juego
        private void iniciar_Click(object sender, EventArgs e)
        {
            //elementos como la cuadricula o los labels de los puntajes pasan a ser visibles cuando comienza el juego
            pictureBox1.Visible = true;
            RestartGame();
            puntaje.Visible = true;
            mejorPuntaje.Visible = true;
        }

        //la siguiente funcion indica mediante un cambio en la variable direcciones en que sentido debe moverse la serpiente
        private void eventoTiempo(object sender, EventArgs e)
        {
            //aqui ajustamos las direcciones

            if (goleft)
            {
                Configuracion.direcciones = "izquierda";
              
            }
            if (goRight)
            {
                Configuracion.direcciones = "derecha";
            }
            if (goUp)
            {
                Configuracion.direcciones = "arriba";
            }
            if (goDown)
            {
                Configuracion.direcciones = "abajo";
            }
            //fin de las direcciones


            //con el nuevo valor de direcciones podemos representar el movimiento mediante la resta o suma de componentes...
            //...del objeto snake dentro de la cuadricula
            for (int i = snake.Count-1; i >= 0; i--)
            {
                if (i == 0)
                {
                    switch (Configuracion.direcciones)
                    {
                        case "izquierda":
                            snake[i].x--;
                            break;
                        case "derecha":
                            snake[i].x++;   
                            break;
                        case "arriba":
                            snake[i].y--;
                            break;
                        case "abajo":
                            snake[i].y++;
                            break;
                        
                    }
                    //En caso de que la serpiente colisione con un borde de la cuadricula se finaliza
                    if (snake[i].x < 0 || snake[i].y < 0 || snake[i].x > maxAncho || snake[i].y > maxAlto)
                    {
                        GameOver();
                        
                    }
                    //Cuando la serpiente se choque con la manzana
                    if (snake[i].x == food.x && snake[i].y == food.y)
                    {   
                        comeComida();
                    }
                    //En caso de que la serpiente colisione consigo misma se finaliza
                    for (int j = 1; j < snake.Count; j++)
                    {
                        if (snake[i].x == snake[j].x && snake[i].y == snake[j].y)
                        {
                            GameOver();
                        }
                    }

                }
                else
                {
                    snake[i].x = snake[i - 1].x;
                    snake[i].y = snake[i - 1].y;
                }
            }
            pictureBox1.Invalidate();
        }

        //Carga ahora si los elementos como la serpiente y la cuadricula 
        private void subirVisual(object sender, PaintEventArgs e)
        {
            //Brush nos ayuda a darle color a los objetos tanto de snake como de food
            Graphics canvas = e.Graphics;
            Brush snakeColor;

            //define la cuadricula 
            int gridSize = Configuracion.ancho; // Tamaño de la celda del grid
            Pen gridPen = new Pen(Color.AliceBlue); // Color de las líneas del grid

            for (int i = 0; i < pictureBox1.Width; i += gridSize)
            {
                canvas.DrawLine(gridPen, i, 0, i, pictureBox1.Height);
            }

            for (int i = 0; i < pictureBox1.Height; i += gridSize)
            {
                canvas.DrawLine(gridPen, 0, i, pictureBox1.Width, i);
            }
            for (int i = 0; i < snake.Count; i++)
            {
                if(i == 0)
                {
                    //la serpiente comienza en 0 con unicamente su cabeza y un cuerpo de una celda
                    //la cabeza se distinguirá del cuerpo con un color más oscuro
                    snakeColor = Brushes.DarkOliveGreen;

                }
                else
                {
                    snakeColor = Brushes.GreenYellow;
                }

                //le brinda este aspecto redondo al cuerpo de la serpiente
                canvas.FillEllipse(snakeColor, new Rectangle(
                    snake[i].x * gridSize,
                    snake[i].y * gridSize,
                    gridSize, gridSize));

            }
            //le brinda aspecto redondo a la manzana food
            canvas.FillEllipse(Brushes.Red, new Rectangle(
                food.x * gridSize,
                food.y * gridSize,
                gridSize, gridSize));


        }
        //Esta funcion se encarga de correr el juego
        private void RestartGame()
        {
           //Deja el valor de los bordes del grid iguales a los del picturebox 
            maxAncho = pictureBox1.Width / Configuracion.ancho - 1;
            maxAlto = pictureBox1.Height / Configuracion.alto - 1;

            //siempre que se inicie o reinicie el juego, el cuerpo de la serpiente será el inicial de 
            //la cabeza y una celda de cuerpo
            snake.Clear();

            //tiempo es un timer en windows forms que nos permite representar en pocas palabras la velocidad con la que se 
            //desplaza la serpiente, a mayor intervalo del timer más lento irá la serpiente
            tiempo.Interval = 200;
            Configuracion.direcciones = "derecha" ;

            //mientras que se este jugando no se puede iniciar otro juego o salir
            iniciar.Enabled = false;
            button2.Enabled = false;

            score = 0;
            puntaje.Text = "Puntaje: " + score;

            //como deciamos anteriormente, la serpiente se divide en dos partes, head y body
            //en la instancia del objeto circle X y Y representan la posicion dentro del picture box de donde partirá
            circle head = new circle {x= 8, y =  8};
            snake.Add(head);// agregandole la cabeza a la snake a la lista

            //el limite del siguiente for representa la cantidad inicial de celdas "cuerpo" que tendra la serpiente
            //... en este caso solo contará con una celda cuerpo al iniciar
            for (int  i = 0; i < 1; i++)
            {
                circle body = new circle();
                snake.Add(body);
            }
            
            //define la posición aleatoria de la manzana
            food = new circle { x = rand.Next(2, maxAncho), y = rand.Next(2,maxAlto)};
            //el timer empieza a correr, aclaramos que como tal este no se reduce solo, sirve como medidor de la velocidad de la serpiente
            tiempo.Start();


        }
        
        private void comeComida() 
        {
            //cuando la cabeza de la serpiente este en la misma casilla que la manzana
            score += 1;
            puntaje.Text = "Tu Puntaje es: " + score;
            //aqui se crea por decirlo asi un nuevo cuerpo para la serpiente para luego agregarlo
            circle body = new circle
            {
                x = snake[snake.Count - 1].x,
                y = snake[snake.Count - 1].y
            };
            snake.Add(body);
            food = new circle { x = rand.Next(2, maxAncho), y = rand.Next(2, maxAlto) };
            //reduciento el intervalo de timer se lográ dar el efecto de que aumenta la velocidad de la serpiente tras comer
            tiempo.Interval = tiempo.Interval - 10;
        }

        
        //cuando se presente una colision con el body o los bordes el juego se detine
        private void GameOver() 
        {
            tiempo.Stop();
            iniciar.Enabled = true;
            button2.Enabled = true;
            //sistema de mejor puntaje
            if (score > highScore)
            {
                highScore = score;
                mejorPuntaje.Text = "Mejor Puntaje: " + Environment.NewLine + highScore;
                mejorPuntaje.ForeColor = Color.Maroon;
                mejorPuntaje.TextAlign = ContentAlignment.MiddleCenter;
            }
        }
        //boton salir
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //doble  click

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void puntaje_Click(object sender, EventArgs e)
        {

        }
    }
}
