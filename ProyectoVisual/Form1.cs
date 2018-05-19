using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ProyectoVisual
{
    public partial class Form1 : Form
    {
        //Archivos
        Archivo archivo;

        Vertice v1 = new Vertice();
        Vertice v2 = new Vertice();

        PictureBox pb;
        Graphics lienzo;
        int tipo, selectMove = -1;                   //selectMove es para el nodo que fue seleccionado para que se mueva
        Grafo grafo;
        int toque = 0;

        List<Vertice> auxVert;
        public Form1()
        {
            InitializeComponent();
            Inicializar();
        }
        
        //Inicializacion de todas las variables
        public void Inicializar()
        {
            archivo = new Archivo();
            pb = new PictureBox();
            lienzo = pictureBox1.CreateGraphics();
            grafo = new Grafo();
            pictureBox1.Enabled = false;
            auxVert = grafo.Vertices;
            Controls.Add(pb);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            //lienzo.Clear(Color.White);
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            pb.Paint += new PaintEventHandler(pictureBox1_Paint);
        }


        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            int i;
            switch (tipo)
            {
                case 0:
                    grafo.AgregaVertice(lienzo, e.X, e.Y);
                    break;
                case 4:
                    for(i = 0;i < auxVert.Count; i++){
                        if (auxVert[i].Seleccion(e.X, e.Y) && toque == 0)
                        {
                            v1 = auxVert[i];
                            toque = 1; 
                        }
                        else if (auxVert[i].Seleccion(e.X, e.Y) && toque == 1)
                        {
                            v2 = auxVert[i];
                            if (!v1.Equals(v2))
                            {
                              
                                lienzo.DrawLine(new Pen(Color.Black), v1.X, v1.Y, v2.X, v2.Y);
                                toque = 0;
                            }
                        }
                    }
                    Console.WriteLine(toque);
                    break;
            }
        }


        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (grafo.Vertices.Count != 0)
            {
                if (MessageBox.Show("Si edita un nuevo archivo archivo los cambios se perderán, está seguro de continuar?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    lienzo.Clear(Color.LightGray);
                    grafo.destruirGrafo();
                }
                else
                    return;
            }
            else
            {
                lienzo.Clear(Color.LightGray);
                /*foreach (Vertice v in grafo.Vertices)
                {
                    v.Aristas.Clear();
                }*/
                grafo.Vertices.Clear();
            }
            
        }


        private void agregarVérticeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tipo = 0;
            pictureBox1.Enabled = true;
        }

       

        private void moverVértiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tipo = 1;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            switch (tipo)
            {
                case 1:
                    for (int i = 0; i < auxVert.Count; i++)
                    {
                        if (auxVert[i].Seleccion(e.X, e.Y))
                        {
                            selectMove = i;
                            //Console.WriteLine(selectMove);
                            break;
                        }
                    }
                    break;      
            }
        }

        private void agregarAristaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tipo = 4;
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (grafo.Vertices.Count != 0)
            {
                if (MessageBox.Show("Si abre un nuevo archivo los cambios se perderán, desea continuar?", "", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }

                
            }

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
               
                archivo.Ruta = openFileDialog1.FileName;

                //destruye grafo anterior
                grafo.destruirGrafo();

                //abre el grafo nuevo
                grafo = archivo.Abrir();
                grafo.Dibujar(lienzo);

                
                //MessageBox.Show(((char)filereader.Read()).ToString());

            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (archivo.Ruta == null)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    archivo.Ruta = saveFileDialog1.FileName;
                }
                else
                    return;
            }
            archivo.Guardar(grafo);
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                archivo.Ruta = saveFileDialog1.FileName;

                archivo.Guardar(grafo);
            }
        }

        

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            
            switch (tipo)
            {
                case 1:
                    //auxVert[selectMove].X = e.X;
                    //auxVert[selectMove].Y = e.Y;
                    //lienzo.Clear(Color.White);
                    //grafo.Vertices[selectMove].Dibujar(lienzo, e.X, e.Y);
                    break;
            }
        }
    }
}
