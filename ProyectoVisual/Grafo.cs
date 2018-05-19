using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ProyectoVisual
{
    class Grafo
    {
        private List<Vertice> vertices;
        private int id;

        public Grafo()
        {
            vertices = new List<Vertice>();
            id = 0;
        }
        public void AgregaVertice(Graphics g, int x, int y)
        {
            bool banColision = false;
            Vertice v = new Vertice(id, x, y);

            for (int i = 0; i < vertices.Count; i++) 
                banColision = x < vertices[i].X + vertices[i].Radio && x > vertices[i].X && y < vertices[i].Y + vertices[i].Radio && y > vertices[i].Y;

            if (!banColision)
            {
                id++;
                vertices.Add(v);
                v.Dibujar(g, x, y);
            }
        }
        public void MoverVertice(int x, int y)
        {

        }
        public void AgregaArista(Graphics g, Vertice v1, Vertice v2, int idV)
        {
            try
            {
                Arista a1 = new Arista(v2, idV);                //v1 ------>  v2
                Arista a2 = new Arista(v1, idV);                //v2 ------>  v1

                Console.WriteLine(vertices[v1.ID].Aristas.Count);
                Console.WriteLine(vertices[v2.ID].Aristas.Count);

                vertices[v1.ID].Aristas.Add(a1);
                vertices[v2.ID].Aristas.Add(a2);

                a1.DibujaArista(g, v1, v2);
            }catch(Exception ex)
            {
                Console.WriteLine("No se puede");
            }

        }
        public List<Vertice> Vertices
        {
            get
            {
                return vertices;
            }
            set
            {
                vertices = value;
            }
        }

        public void Dibujar(Graphics g)
        {
            g.Clear(Color.LightGray);
            foreach (Vertice v in vertices)
                v.Dibujar(g, v.X, v.Y);
        }

        public void destruirGrafo()
        {
            vertices.Clear();
            id = 0;
        }
    }
}
