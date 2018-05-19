using System;


using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ProyectoVisual
{
    class Arista
    {
        private int id;
        private Vertice final;

        public Arista(Vertice v, int i)
        {
            final = v;
            id = i;
        }
        public Vertice Final
        {
            get
            {
                return final;
            }
            set
            {
                final = value;
            }
        }
        public int ID
        {
            set
            {
                id = value;
            }
            get
            {
                return id;
            }
        }
        public void DibujaArista(Graphics g, Vertice v1, Vertice v2)
        {
            Pen pablo = new Pen(Color.Black);

            g.DrawLine(pablo, v1.X, v1.Y, v2.X, v2.Y);
        }
    }
}
