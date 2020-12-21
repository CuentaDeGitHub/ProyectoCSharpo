using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;


namespace ProyectoEstructurasCSharp
{
    public partial class FormularioGrafo : Form
    {
        List<NodoGrafo> nodos = new List<NodoGrafo>();
        int bandera;
        Graphics dibujo;
        public FormularioGrafo()
        {
            InitializeComponent();
        }

        private void FormularioGrafo_Load(object sender, EventArgs e)
        {

        }
        public void dibuja()
        {
            List<NodoGrafo> aux = new List<NodoGrafo>();
            aux = nodos;

            if (dibujo != null)
            {
                dibujo.Clear(Color.Aqua);
            }

            dibujo = this.pictureBox1.CreateGraphics();
            Font fonnt1 = new Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point);
            for (int i = 0; i < aux.Count(); i++)
            {
                float xletra = (float)aux[i].getX() + 15;
                float yletra = (float)aux[i].getY() + 15;
                dibujo.FillEllipse(Brushes.Pink, aux[i].getX(), aux[i].getY(), 40, 40);
                dibujo.DrawString(aux[i].getnombre().ToString(), fonnt1, Brushes.Purple, xletra, yletra);

            }
            for (int i = 0; i < aux.Count(); i++)
            {
                if (aux[i].aristas != null)
                {
                    for (int j = 0; j < aux[i].aristas.Count(); j++)
                    {
                        if (aux[i].aristas[j].getTipo() == 0)
                        {


                            Pen pen = new Pen(Color.Black, 3);
                            pen.EndCap = LineCap.ArrowAnchor;
                            float xletra = Math.Abs(((float)nodos[aux[i].aristas[j].getOrigen()].getX() + (float)nodos[aux[i].aristas[j].getDestino()].getX()) / 2);
                            float yletra = Math.Abs(((float)nodos[aux[i].aristas[j].getOrigen()].getY() + (float)nodos[aux[i].aristas[j].getDestino()].getY()) / 2);
                            dibujo.DrawLine(pen, aux[aux[i].aristas[j].getOrigen()].getX() + 20, aux[aux[i].aristas[j].getOrigen()].getY() + 20,
                                aux[aux[i].aristas[j].getDestino()].getX() + 20, aux[aux[i].aristas[j].getDestino()].getY() + 20);
                            dibujo.DrawString(aux[i].aristas[j].getPeso().ToString(), fonnt1, Brushes.Purple, xletra, yletra);


                        }
                        else if (aux[i].aristas[j].getTipo() == 1)
                        {
                            Pen pen = new Pen(Color.Black, 3);
                            float xletra = Math.Abs(((float)nodos[aux[i].aristas[j].getOrigen()].getX() + (float)nodos[aux[i].aristas[j].getDestino()].getX()) / 2);
                            float yletra = Math.Abs(((float)nodos[aux[i].aristas[j].getOrigen()].getY() + (float)nodos[aux[i].aristas[j].getDestino()].getY()) / 2);
                            dibujo.DrawLine(pen, aux[aux[i].aristas[j].getOrigen()].getX() + 20, aux[aux[i].aristas[j].getOrigen()].getY() + 20,
                                aux[aux[i].aristas[j].getDestino()].getX() + 20, aux[aux[i].aristas[j].getDestino()].getY() + 20);
                            dibujo.DrawString(aux[i].aristas[j].getPeso().ToString(), fonnt1, Brushes.Purple, xletra, yletra);
                        }
                    }
                }
            }
        }




        int cordx = new int();
        int cordy = new int();
        bool binicio = false;
        bool bfinal = false;
        int inicio = 10000;

        public void acciones1()
        {
            int eliminar = 1000;
            if (bandera == 1)
            {
                NodoGrafo nod = new NodoGrafo();
                nod.llenaNodo(cordx - 20, cordy - 20);
                nod.llenanombre(nodos.Count());
                nodos.Add(nod);
                dibuja();
            }

            if (bandera == 2)
            {
                dibuja();
            }
            if (bandera == 3)
            {
                for (int i = 0; i < nodos.Count(); i++)
                {
                    if (cordx > nodos[i].getX() - 40 && cordx < nodos[i].getX() + 40 && cordy > nodos[i].getY() - 40 && cordy < nodos[i].getY() + 40) //checar el que toco
                    {
                        eliminar = i;
                    }
                }
                if (eliminar != 1000)
                {
                    nodos.RemoveAt(eliminar);
                    dibuja();
                }
            }
            if (bandera == 4)
            {
                for (int i = 0; i < nodos.Count(); i++)
                {
                    if (cordx > nodos[i].getX() - 40 && cordx < nodos[i].getX() + 40 && cordy > nodos[i].getY() - 40 && cordy < nodos[i].getY() + 40)
                    {
                        inicio = i;
                        binicio = true;

                    }
                }
                if (bfinal == true && binicio == true)
                {
                    dibuja();
                    bfinal = false;
                    binicio = false;
                }
            }
            if (bandera == 5)
            {
                for (int i = 0; i < nodos.Count(); i++)
                {
                    if (cordx > nodos[i].getX() - 40 && cordx < nodos[i].getX() + 40 && cordy > nodos[i].getY() - 40 && cordy < nodos[i].getY() + 40)
                    {
                        inicio = i;
                        binicio = true;

                    }
                }
                if (bfinal == true && binicio == true)
                {
                    dibuja();
                    bfinal = false;
                    binicio = false;
                }
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            cordx = e.Location.X;
            cordy = e.Location.Y;
            int final = 1000;
            if (bandera == 4)
            {
                if (binicio == true)
                {
                    Arista arista = new Arista();
                    for (int i = 0; i < nodos.Count(); i++)
                    {
                        if (cordx > nodos[i].getX() - 40 && cordx < nodos[i].getX() + 40 && cordy > nodos[i].getY() - 40 && cordy < nodos[i].getY() + 40)
                        {
                            final = i;
                            bfinal = true;
                            arista.llenaArista(inicio, final, 0, 0);
                            nodos[inicio].llenararista(arista);
                        }
                    }
                }
            }
            if (bandera == 5)
            {
                if (binicio == true)
                {
                    Arista arista = new Arista();
                    for (int i = 0; i < nodos.Count(); i++)
                    {
                        if (cordx > nodos[i].getX() - 40 && cordx < nodos[i].getX() + 40 && cordy > nodos[i].getY() - 40 && cordy < nodos[i].getY() + 40)
                        {
                            final = i;
                            bfinal = true;
                            arista.llenaArista(final, inicio, 0, 1);
                            nodos[final].llenararista(arista);
                        }
                    }
                }
            }
            if (bandera == 6)
            {
                for (int i = 0; i < nodos.Count; i++)
                {
                    for (int j = 0; j < nodos[i].aristas.Count; j++)
                    {
                        int m = (nodos[nodos[i].aristas[j].getOrigen()].getX() - nodos[nodos[i].aristas[j].getDestino()].getX()) / (nodos[nodos[i].aristas[j].getOrigen()].getY() - nodos[nodos[i].aristas[j].getDestino()].getY());
                    }
                }
            }

            acciones1();

        }

        bool minicio = false;
        int xinicio = 0;
        int yinicio = 0;
        int nodmover = 1000;

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (bandera == 2)
            {
                for (int i = 0; i < nodos.Count(); i++)
                {
                    if (cordx > nodos[i].getX() - 40 && cordx < nodos[i].getX() + 40)
                    {
                        xinicio = cordx;
                        yinicio = cordy;
                        minicio = true;
                        nodmover = i;
                    }
                }
            }
            if (bandera == 7)
            {
                for (int i = 0; i < nodos.Count(); i++)
                {
                    if (e.Location.X > nodos[i].getX() - 40 && e.Location.X < nodos[i].getX() + 40 && e.Location.Y > nodos[i].getY() - 40 && e.Location.Y < nodos[i].getY() + 40)
                    {
                        xinicio = cordx;
                        yinicio = cordy;
                        minicio = true;
                        nodmover = i;
                    }
                }
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            int xdif = 0;
            int ydif = 0;
            NodoGrafo nd = new NodoGrafo();
            if (bandera == 2 && minicio == true)
            {
                xdif = e.Location.X - xinicio;
                ydif = e.Location.Y - yinicio;
                for (int i = 0; i < nodos.Count; i++)
                {
                    nodos[i].llenaNodo(nodos[i].getX() + xdif, nodos[i].getY() + ydif);
                }
                dibuja();
                minicio = false;
            }

            if (bandera == 7 && minicio == true)
            {
                xdif = e.Location.X - nodos[nodmover].getX();
                ydif = e.Location.Y - nodos[nodmover].getY();
                nodos[nodmover].llenaNodo(nodos[nodmover].getX() + xdif, nodos[nodmover].getY() + ydif);
                dibuja();
                minicio = false;
            }
        }

        List<NodoGrafo> auxmover;

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            int xxdif;
            int yydif;

            List<NodoGrafo> auxnodo = nodos;
            if (bandera == 2 && minicio == true)
            {
                xxdif = e.Location.X - xinicio;
                yydif = e.Location.Y - yinicio;
                for (int i = 0; i < auxnodo.Count; i++)
                {
                    auxnodo[i].llenaNodo(auxnodo[i].getX() + xxdif, auxnodo[i].getY() + yydif);
                }
                dibuja();
            }

            if (bandera == 7 && minicio == true)
            {
                xxdif = e.Location.X - auxnodo[nodmover].getX();
                yydif = e.Location.Y - auxnodo[nodmover].getY();
                auxnodo[nodmover].llenaNodo(auxnodo[nodmover].getX() + xxdif, auxnodo[nodmover].getY() + yydif);
                dibuja();
            }
        }

        private void grafo1ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            MatrizAdyacencia hiMoa = new MatrizAdyacencia();
            hiMoa.Show();
        }

        private void grafo1ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            MatrizPeso byeMoa = new MatrizPeso(nodos);
            byeMoa.Show();
        }

        private void Grafos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void grafo1ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            nodos = new List<NodoGrafo>();
            dibuja();
        }

        private void grafo1ToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            nodos = new List<NodoGrafo>();
            dibuja();
            pictureBox1.Image = null;
        }

        private void grafo1ToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            bandera = 1;
        }

        private void moverTodoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            bandera = 2;
        }

        private void moverNodoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            bandera = 7;
        }

        private void eliminarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            bandera = 3;
        }

        private void dirigidaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            bandera = 4;
        }

        private void noDirigidaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            bandera = 5;
        }

        private void eliminarToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            bandera = 6;
        }

        private void adyacenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void grafo1ToolStripMenuItem3_Click_1(object sender, EventArgs e)
        {
            MatrizAdyacencia hiMoa = new MatrizAdyacencia(nodos);
            hiMoa.Show();
        }

        private void grafo1ToolStripMenuItem4_Click_1(object sender, EventArgs e)
        {
            MatrizPeso byeMoa = new MatrizPeso(nodos);
            byeMoa.Show();
        }
    }
}
