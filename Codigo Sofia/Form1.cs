﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Candy
{
    public partial class Form1 : Form
    {
        Form2 Form2 = new Form2();
        Tablero tab;    //Iniciamos una variable de clase tablero tablero
        Button[,] matrizBotones;
        int puntaje = 0;
        int casillas = 0;
        int[,] matrizPosiciones = new int[5,2];
        public String username {  get; set; }
        public bool registrado;

        public Dictionary<string, string[]> dicJugadores;

        //Matriz grande de maximo 5 coordenadas para verificar, cada coordenada x es un par



        public Form1()
        {
            //Método generado automaticamente
            InitializeComponent();
            //Mi objeto tablero

            tab = new Tablero(8, 8, 6);     //tablero 8x8 de 6 tipos de caramelos
      

        }
       

        //-----NOTAS DE MIGUEL--------
        //Si queremos acceder a la matriz de numeros entonces vamos usar tab.valores y a la matriz de imagenes vamos a usar MatPictureBox
        //Tendriamos una matriz fija de 8x8, donde usariamos 64 botones cada uno asignado a una coodenada, la cual se encargara de evaluar arriba, abajo, izquierda, derecha

            


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
                case 5:
                    return global::Candy.Properties.Resources._5;
                default:
                    return global::Candy.Properties.Resources._6;
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
             bool ban = true;
            while ((EnlineaPosible(tab.valores)!=2)||ban)   //ciclo para que exista almenos 3 en linea posibles de hacer
            {
              
                if(EnlineaPosible(tab.valores) == 2)
                {
                    for (int i = 0; i < filas; i++)
                    {
                        for (int j = 0; j < columnas; j++)
                        {
                            //Logica para la asignacion de las imagenes a los botones

                            Button btn = new Button();      //Creamos un boton que sera parte de la matriz
                            btn.FlatStyle = FlatStyle.Flat;
                            btn.Size = new Size(45, 45);
                            btn.BackColor = Color.Transparent;
                           
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
                    ban = false;
                }
                else 
                {
                    tab.iniciarJuego(6);
                  //  tab = new Tablero(8, 8, 6);

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
            if (numbtn >= 3)
            {
                int[] vectorNumeros = new int[numbtn];      //Este vector almacena todos los numeros de las coordenadas seleccionadas para comparar si son iguales y ver si hay 3 en linea

                for (int i = 0; i < numbtn; i++)   //Este ciclo se encaragará de comprobar que las coordenadas en en tablero de numeros sean las mismas
                {
                    int coordenadax = matrizPosiciones[i, 0];
                    int coordenaday = matrizPosiciones[i, 1];

                    vectorNumeros[i] = tab.valores[coordenadax, coordenaday];

                    //  MessageBox.Show($"coordenada X y Y del boton seleccionado son {coordenadax} y {coordenaday}"); verificador de que ya recolectamos las coordenadas

                    //MessageBox.Show($"En la matriz de numeros es {vectorNumeros[i]}");
                }

                bool linea = EnLinea(Horientacion(matrizPosiciones), matrizPosiciones, vectorNumeros);
                if (linea)
                {
                    //MessageBox.Show("Si hay 3 en linea");
                    // Asignar -1 a los elementos de la matriz tab.valores correspondientes a los botones seleccionados
                    for (int i = 0; i < numbtn; i++)
                    {
                        int fila = matrizPosiciones[i, 0];
                        int columna = matrizPosiciones[i, 1];

                        tab.valores[fila, columna] = -1;


                        // Obtener el botón correspondiente al índice en el TableLayoutPanel
                        //Button boton = matrizBotones[fila, columna];

                        // Actualizar la imagen del botón
                        //boton.BackgroundImage = seleccionarRecursoCaramelo(-1);

                    }

                    Cascada(tab.valores);
                    switch (casillas)
                    {
                        case 3:     //variacion de los puntajes
                            puntaje = puntaje + 6;
                            break;
                        case 4:
                            puntaje = puntaje + 10;
                            break;
                        default:
                            puntaje = puntaje + 15;
                            break;
                    }
                    Score.Text = puntaje.ToString(); //Mostramos los puntajes en el forms
                    casillas = 0;
                    // aqui es para que se refresque con las nuevas celdas
                    for (int rows = 7; rows >= 0; rows--)
                    {
                        for (int cols = 0; cols <= 7; cols++)
                        {
                            Button botonF = matrizBotones[rows, cols];
                            int caramelo = tab.valores[rows, cols];
                            botonF.BackgroundImage = seleccionarRecursoCaramelo(caramelo); //Le asociamos una imagen al boton

                            botonF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                        }
                    }
                    // Actualizar la apariencia del TableLayoutPanel
                    matrizBform.Refresh();

                }
                else
                {
                    MessageBox.Show("No hay 3 en linea");
                    puntaje = puntaje - 5;
                    Score.Text = puntaje.ToString();
                }
                if (EnlineaPosible(tab.valores) == 0)   //Caso en el que acaba el juego
                {
                    Form2.StartPosition = FormStartPosition.CenterScreen;
                    
                    Form2.Show();

                    Dictionary<string, string[]> dicJugadores = DicSesion();   //dicJugadores sera la variable que contiene el diccionario
                    List<string> listaDeJugadores = new List<string>(dicJugadores.Keys);

                    DateTime fechaHoraActual = DateTime.Now;              
                    string cadenaFechaHora = fechaHoraActual.ToString("yyyy-MM-dd HH:mm:ss");   //Fecha y hora en string

                    if (listaDeJugadores.Contains(username))     //Caso en que ya exista en el txt
                    {
                        string puntajeDic = dicJugadores[username][0];
                        int puntajeDicI = int.Parse(puntajeDic);

                        if(puntaje > puntajeDicI)   //Si el puntaje del obtenido es mayor que el del diccionario
                        {
                            dicJugadores[username][0] = puntaje.ToString();
                            dicJugadores[username][1] = cadenaFechaHora;
                        }
                    }
                    else //No existe en el TXT
                    {
                        dicJugadores.Add(username,new string[] {puntaje.ToString(),cadenaFechaHora});
                    }
                    LimpiarArchivo("Archivo.txt");
                    EscribirDiccionarioEnArchivo(dicJugadores,"Archivo.txt");
                   

                }           
            }
            else
            {
                MessageBox.Show("Deben haber minimo tres caramelos seleccionados ");
            }



            numbtn =0;   //Volvemos cero este contador para que vuelva a contar las varibles          
        }//Fin evento VERIFICAR

        private void buttonSALIR_Click(object sender, EventArgs e)  //SALIR 
        {
            this.Close();
        }




        public bool Horientacion(int[,] matPos) //Esta funcion me dira si el 3 en linea es horizontal o vertical
        {
            if (matPos[0,0] == matPos[1,0]) //con que 2 bootnes coicidan en posiciones principales o no podemos determinar si es vertical o horizontal
            {
                return true;    
            }
            else
            { 
                return false;
            }
        }   //retorna True si es horizontal y False si es vertical


        public bool EnLinea(bool horientacion, int[,] matPos, int[] valores)
        {
            bool comprobacion = true;

            //Comprobamos si todos estan en la misma horientacion
            if (horientacion)   //Si es horizontal
            {
                int valorBase = matPos[0, 0];
                for (int i = 0; i < valores.Length; i++)
                {
                    if (matPos[i, 0] != valorBase)   //caso donde haya un valor que no este en esa fila
                    {
                        comprobacion = false;
                       
                        MessageBox.Show("Hay uno que no esta en la misma fila horizontal");

                    }
                }
            }
            else //Si es vertical
            {
                int valorBase = matPos[0, 1];
                for (int i = 0; i < valores.Length; i++)
                {
                    if (matPos[i, 1] != valorBase)   //caso donde haya un valor que no este en esa fila
                    {
                        comprobacion = false;

                        MessageBox.Show("Hay uno que no esta en la misma fila vertical");

                    }
                }
            }

            if(!comprobacion) //caso donde no esten todos en la misma horientacion por ende no es 3 en linea
            {
                //MessageBox.Show("La primera comprobacion es falsa");
                return false;
                
            }

            else //caso donde esten todos en la misma horientacion
            {
                bool comprobacion2 = true;
                //Vamos a comprobar que todos los valores sean del mismo tipo para ejecutar el tres en linea
                for (int valor=0;  valor < valores.Length-1; valor++)
                {
                    if (valores[valor] != valores[valor + 1])
                    {
                        comprobacion2= false;
                     
                    }
                }

                if (!comprobacion2) //Caso hay un valor que no es igual
                {
                   // MessageBox.Show(" Hay un valor diferente en la matriz de numeros");
                    return false;

                }

                else //Caso en que todos los valores son iguales
                {

                    //Ahora vamos a verificar que todos esten pegados

                    bool comprobacion3 = true;

                    if (horientacion)   //caso horizontal
                    {
                        int[] vectCor = new int[valores.Length];
                        for (int i = 0;i < vectCor.Length; i++)
                        {
                            vectCor[i] = matPos[i, 1];  //vectCor va a tener el valor de la coordenada Y de la matriz de posiciones...
                        }                               //...osea de la coordenada que varia sabiendo que estan en la misma fila

                        Array.Sort(vectCor);

                        
                        for (int valor = 0; valor < valores.Length - 1; valor++)
                        {
                            if ((vectCor[valor+1] - vectCor[valor])!=1)
                            {
                                MessageBox.Show($"{vectCor[valor + 1]}-{vectCor[valor]}");
                                comprobacion3 = false;
                            }
                        }
                    }

                    else //vertical
                    {
                        int[] vectCor = new int[valores.Length];
                        for (int i = 0; i < vectCor.Length; i++)
                        {
                            vectCor[i] = matPos[i, 0];  //vectCor va a tener el valor de la coordenada Y de la matriz de posiciones...
                        }                               //...osea de la coordenada que varia sabiendo que estan en la misma fila

                        Array.Sort(vectCor);

                       
                        for (int valor = 0; valor < valores.Length - 1; valor++)
                        {
                            if ((vectCor[valor+1] - vectCor[valor]) != 1)
                            {
                               
                                comprobacion3 = false;
                            }
                        }
                    }

                    if (comprobacion3)  //Caso en que si se cumplieron todas las condiciones anteriores por ende es 3 en linea
                    {
                        //MessageBox.Show("Estan pegados");
                       
                        return true;
                    }
                    else
                    {
                        //MessageBox.Show("No estan pegados");
                        return false;
                    }
                }
            }
        }   //Fin3enLinea
    
        public void Cascada(int[,] matPos)
        {
            Random random = new Random(); //Creamos un objeto random
            //valid es prevenir que en caso de ser tres en vertical, el mas de abajo quede en -1
            //lo que hace es simplemente pegarle una nueva revisada a toda la matriz 
            for(int valid = 3 ;valid >0; valid--)
            {
                for (int i = 7; i >= 0; i--)
                {
                    for (int j = 0; j <= 7; j++)
                    {
                        if (matPos[i, j] == -1)
                        {
                            casillas++;
                            int filaDestino = i;
                            for (int m = i - 1; m >= 0; m--)
                            {
                                matPos[filaDestino, j] = matPos[m, j];
                                matPos[m, j] = -2;
                                filaDestino--;
                            }
                        }
                        // este if es para asegurarnos que si sale un tres en linea en la fila 0 tambien lo cambie
                        if (matPos[i,j] == -1 && i == 0)
                        {
                            casillas++;
                            matPos[i, j] = -2;
                        }

                        // aqui lo que hacemos es que se le asigne un valor nuevo a esas casillas que quedaron vacias "-2"
                        if (matPos[i, j] == -2)
                        {
                            matPos[i, j] = random.Next(6);
                        }
                    }
                }
            }
            
            
           
        }

        public int EnlineaPosible(int[,] matrizNum)    //Esta funcion tiene como parametro la matriz de numeros y sirve para verificar que...
        {                                             //...exista al menos un tres en linea, esta funcion solo puede tener tres retornos
                                                      // 0-->No hay posiblidad de tres en linea   1-->Existe almenos uno   2-->Existe almenos 3

            int cont = 0;
            for (int i = 0; i < 8; i++) //Evaluaremos de manera horizontal 
            {
                for (int j = 0;j < 6; j++)
                {
                    if (matrizNum[i, j] == matrizNum[i, j + 1]) //el primero es igual al segundo
                    {
                        if (matrizNum[i, j+1] == matrizNum[i, j + 2])   //El segundo es igual al tercero
                        {
                            cont++; //posible tres en linea
                        }
                    }
                }
            }

            for (int j = 0; j<8; j++)
            {
                for(int i = 0;i < 6; i++)
                {
                    if (matrizNum[i, j] == matrizNum[i + 1, j]) //El primero es igual al segundo
                    {
                        if (matrizNum[i+1,j] == matrizNum[i + 2, j])    //El segundo es igual al tercero
                        {
                            cont++; //posible tres en linea
                        }
                    }
                }
            }

            if(cont == 0)   //Ninguna posibilidad de tres en linea
            {
                return 0;
            }
            else
            {
                if (cont < 3)   //Existe al menos uno pero menos de 3
                {
                    return 1;
                }
                else  //Existen almenos 3
                {
                    return 2;
                }
            }

        }


        //FUNCIONES DE INICIO DE SESION
        public Dictionary<string, string[]>  DicSesion()
        {
            Dictionary<string, string[]> datosUsuarios = new Dictionary<string, string[]>();
            try
            {
                // Obtener el directorio del archivo ejecutable
                string directorioActual = AppDomain.CurrentDomain.BaseDirectory;

                // Combinar el directorio con el nombre del archivo
                string rutaArchivo = Path.Combine(directorioActual, "Archivo.txt");

                // Crear un diccionario para almacenar los datos
                
                // Leer todas las líneas del archivo
                string[] lineas = File.ReadAllLines(rutaArchivo);

                // Procesar cada línea del archivo
                foreach (string linea in lineas)
                {

                    // Dividir la línea en partes utilizando el punto y coma como separador
                    string[] partes = linea.Split(';');

                    // Verificar si la línea tiene el formato esperado
                    if (partes.Length == 3)
                    {
                        // Obtener los valores de la línea
                        string nombreUsuario = partes[0];
                        string fechaHora = partes[2];
                        string ultimoNumero = partes[1];

                        // Crear un vector con la fecha y hora y el último número
                        string[] datosUsuario = { ultimoNumero, fechaHora };

                        // Agregar al diccionario
                        datosUsuarios.Add(nombreUsuario, datosUsuario);
                        
                    }
                    else
                    {
                        Console.WriteLine($"Formato incorrecto en la línea: {linea}");
                    }

                }
                return datosUsuarios;

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al leer el archivo: {ex.Message}");
                return datosUsuarios;
            }

        }

        public void EscribirDiccionarioEnArchivo(Dictionary<string, string[]> datos, string nombreArchivo)
        {
            try
            {

                // Crear o agregar al final del archivo
                using (StreamWriter escritor = new StreamWriter(nombreArchivo, true))
                {
                    // Escribir cada entrada del diccionario en el archivo
                    foreach (var parClaveValor in datos)
                    {
                        // Formatear la línea como "fecha;usuario;fecha_y_hora"
                        string linea = $"{parClaveValor.Key};{parClaveValor.Value[0]};{parClaveValor.Value[1]}";
                        escritor.WriteLine(linea);
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al leer el archivo: {ex.Message}");
            }
        }


        public void LimpiarArchivo(string nombreArchivo)
        {
            try
            {
                // Crear o agregar al final del archivo
                using (StreamWriter escritor = new StreamWriter(nombreArchivo))
                {
                    // Escribir cada entrada del diccionario en el archivo                
                        escritor.WriteLine("");                    
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al leer el archivo: {ex.Message}");
            }
        }

        public string[] ObtenerClavesOrdenadas(Dictionary<string, string[]> diccionario)    //Retorna una lista con las claves ordenadas en base al segundo parametro
        {
            // Ordenar las claves según el valor numérico de string2
            string[] clavesOrdenadas = diccionario.Keys.OrderByDescending(clave =>
            {
                if (int.TryParse(diccionario[clave][0], out int valorNumerico))
                {
                    return valorNumerico;
                }
                else
                {
                    // Manejar el caso en el que el valor de string2 no sea un número válido
                    // Puedes ajustar esto según tus requisitos (por ejemplo, tratando el error o asignando un valor predeterminado)
                    return 0;
                }
            }).ToArray();

            return clavesOrdenadas;
        }



        private void button1_Click(object sender, EventArgs e)  //Boton de mejores puntajes
        {
            Dictionary<string, string[]> dicJugadores = DicSesion();
            string[] claves = ObtenerClavesOrdenadas(dicJugadores);
            Form4 puntajesForm = new Form4();
            switch (claves.Length)
            {
                case 1:
                    puntajesForm.textNum1.Text = $"Username:{claves[0]}     puntaje:{dicJugadores[claves[0]][0]}   Fecha:{dicJugadores[claves[0]][1]} ";
                    break;
                case 2:
                    puntajesForm.textNum1.Text = $"Username:{claves[0]}     puntaje:{dicJugadores[claves[0]][0]}   Fecha:{dicJugadores[claves[0]][1]} ";
                    puntajesForm.textNum2.Text = $"Username:{claves[1]}     puntaje:{dicJugadores[claves[1]][0]}   Fecha:{dicJugadores[claves[1]][1]} ";
                    break;
                case 3:
                    puntajesForm.textNum1.Text = $"Username:{claves[0]}     puntaje:{dicJugadores[claves[0]][0]}   Fecha:{dicJugadores[claves[0]][1]} ";
                    puntajesForm.textNum2.Text = $"Username:{claves[1]}     puntaje:{dicJugadores[claves[1]][0]}   Fecha:{dicJugadores[claves[1]][1]} ";
                    puntajesForm.textNum3.Text = $"Username:{claves[2]}     puntaje:{dicJugadores[claves[2]][0]}   Fecha:{dicJugadores[claves[2]][1]} ";
                    break;
                case 4:

                    puntajesForm.textNum1.Text = $"Username:{claves[0]}     puntaje:{dicJugadores[claves[0]][0]}   Fecha:{dicJugadores[claves[0]][1]} ";
                    puntajesForm.textNum2.Text = $"Username:{claves[1]}     puntaje:{dicJugadores[claves[1]][0]}   Fecha:{dicJugadores[claves[1]][1]} ";
                    puntajesForm.textNum3.Text = $"Username:{claves[2]}     puntaje:{dicJugadores[claves[2]][0]}   Fecha:{dicJugadores[claves[2]][1]} ";
                    puntajesForm.textNum4.Text = $"Username:{claves[3]}     puntaje:{dicJugadores[claves[3]][0]}   Fecha:{dicJugadores[claves[3]][1]} ";
                    break;
                case 5:
                    puntajesForm.textNum1.Text = $"Username:{claves[0]}     puntaje:{dicJugadores[claves[0]][0]}   Fecha:{dicJugadores[claves[0]][1]} ";
                    puntajesForm.textNum2.Text = $"Username:{claves[1]}     puntaje:{dicJugadores[claves[1]][0]}   Fecha:{dicJugadores[claves[1]][1]} ";
                    puntajesForm.textNum3.Text = $"Username:{claves[2]}     puntaje:{dicJugadores[claves[2]][0]}   Fecha:{dicJugadores[claves[2]][1]} ";
                    puntajesForm.textNum4.Text = $"Username:{claves[3]}     puntaje:{dicJugadores[claves[3]][0]}   Fecha:{dicJugadores[claves[3]][1]} ";
                    puntajesForm.textNum5.Text = $"Username:{claves[4]}     puntaje:{dicJugadores[claves[4]][0]}   Fecha:{dicJugadores[claves[4]][1]} ";
                    break;
            }

          




            puntajesForm.Show();
        }















        /////////////////////---EVENTOS ACCIDENTALES------/////////////////////////////      
        private void matrizBform_Paint(object sender, PaintEventArgs e)
        {
        }
        // doble click en el forms xd
        private void button3_Click(object sender, EventArgs e)
        {          
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            buttonSALIR.PerformClick();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            VerificarButtom.PerformClick();
        }

        private void label1_Click(object sender, EventArgs e)
        {
         
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

     
        /////////////////////////////////////////////////////////////////////////

    }
}
