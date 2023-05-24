using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructores
{
    internal class Punto
    {
        public int X { get; set; }
        public int Y { get; set; }

        // El constructor tiene el nombre de la clase
        public Punto()
        {
            X = 0;
            Y = 0;
        }

        public Punto(int x, int y)
        {
            X = x;
            Y = y;
            
        }

        public Punto(int x)
        {
            X = x;
        }
    }
}
