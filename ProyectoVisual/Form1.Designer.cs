﻿namespace ProyectoVisual
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarVérticeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moverVértiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarVérticeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aristaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarAristaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarAristaDirigidaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarAristaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 31);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(896, 412);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.aristaToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(923, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.guardarComoToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // guardarComoToolStripMenuItem
            // 
            this.guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            this.guardarComoToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.guardarComoToolStripMenuItem.Text = "Guardar como...";
            this.guardarComoToolStripMenuItem.Click += new System.EventHandler(this.guardarComoToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarVérticeToolStripMenuItem,
            this.moverVértiveToolStripMenuItem,
            this.eliminarVérticeToolStripMenuItem});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.editarToolStripMenuItem.Text = "Vértice";
            // 
            // agregarVérticeToolStripMenuItem
            // 
            this.agregarVérticeToolStripMenuItem.Name = "agregarVérticeToolStripMenuItem";
            this.agregarVérticeToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.agregarVérticeToolStripMenuItem.Text = "Agregar vértice";
            this.agregarVérticeToolStripMenuItem.Click += new System.EventHandler(this.agregarVérticeToolStripMenuItem_Click);
            // 
            // moverVértiveToolStripMenuItem
            // 
            this.moverVértiveToolStripMenuItem.Name = "moverVértiveToolStripMenuItem";
            this.moverVértiveToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.moverVértiveToolStripMenuItem.Text = "Mover vértice";
            this.moverVértiveToolStripMenuItem.Click += new System.EventHandler(this.moverVértiveToolStripMenuItem_Click);
            // 
            // eliminarVérticeToolStripMenuItem
            // 
            this.eliminarVérticeToolStripMenuItem.Name = "eliminarVérticeToolStripMenuItem";
            this.eliminarVérticeToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.eliminarVérticeToolStripMenuItem.Text = "Eliminar vértice";
            // 
            // aristaToolStripMenuItem
            // 
            this.aristaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarAristaToolStripMenuItem1,
            this.agregarAristaDirigidaToolStripMenuItem1,
            this.eliminarAristaToolStripMenuItem1});
            this.aristaToolStripMenuItem.Name = "aristaToolStripMenuItem";
            this.aristaToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.aristaToolStripMenuItem.Text = "Arista";
            // 
            // agregarAristaToolStripMenuItem1
            // 
            this.agregarAristaToolStripMenuItem1.Name = "agregarAristaToolStripMenuItem1";
            this.agregarAristaToolStripMenuItem1.Size = new System.Drawing.Size(234, 26);
            this.agregarAristaToolStripMenuItem1.Text = "Agregar arista";
            this.agregarAristaToolStripMenuItem1.Click += new System.EventHandler(this.agregarAristaToolStripMenuItem1_Click);
            // 
            // agregarAristaDirigidaToolStripMenuItem1
            // 
            this.agregarAristaDirigidaToolStripMenuItem1.Name = "agregarAristaDirigidaToolStripMenuItem1";
            this.agregarAristaDirigidaToolStripMenuItem1.Size = new System.Drawing.Size(234, 26);
            this.agregarAristaDirigidaToolStripMenuItem1.Text = "Agregar arista dirigida";
            // 
            // eliminarAristaToolStripMenuItem1
            // 
            this.eliminarAristaToolStripMenuItem1.Name = "eliminarAristaToolStripMenuItem1";
            this.eliminarAristaToolStripMenuItem1.Size = new System.Drawing.Size(234, 26);
            this.eliminarAristaToolStripMenuItem1.Text = "Eliminar arista";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.CheckFileExists = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 457);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Editor de Grafos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarVérticeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moverVértiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarVérticeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aristaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarAristaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem agregarAristaDirigidaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eliminarAristaToolStripMenuItem1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

