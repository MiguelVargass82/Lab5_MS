using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snakee
{
    internal class circle
    {
        //Hace referencia a posiciones que luego pasaran a llamarse dentro del recuadro de juego
        public int x { get; set; }
        public int y { get; set; }

        public circle()
        {
            x = 7;
            y = 8;
        }
    }
}
