﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ProyectoVisual
{
    class Vertice
    {
        private int id;
        private int x, y;               //
        private int xv, yv, radio = 18;
        private List<Arista> a;

        public Vertice(int id_in,int X,int Y)
        {
            id = id_in;
            radio = 18;
            x = X;
            y = Y;
        }
        public Vertice()
        {
            id = 00;
            radio = 18;
        }
        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
        public int XV
        {
            get
            {
                return xv;
            }
            set
            {
                xv = value;
            }
        }
        public int YV
        {
            get
            {
                return yv;
            }
            set
            {
                yv = value;
            }
        }
        public int Radio
        {
            get
            {
                return radio;
            }
            set
            {
                radio = value;
            }
        }
        public void Dibujar(Graphics g,int xM,int yM)
        {
            Pen juan = new Pen(Color.Blue);
            Font letra = new Font("Arial", 20);
            SolidBrush brocha = new SolidBrush(Color.Black);

            g.DrawEllipse(juan, xM - radio, yM - radio, radio * 2, radio * 2);
            g.DrawString(Convert.ToString(id + 1), letra, brocha, xM - radio + 5, yM - radio + 3);

        }
        public bool Seleccion(int xP, int yP)
        {
            // Los parametos de entrada son las coordenadas del click
            bool resp = false;

            if (xP <= x + radio && xP >= x - radio && yP <= y + radio && yP >= y - radio)
                resp = true;

            return resp;
        }
        public List<Arista> Aristas
        {
            get
            {
                return a;
            }
            set
            {
                a = value;
            }
        }
    }
}
