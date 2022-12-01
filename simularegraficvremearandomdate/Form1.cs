using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace simularegraficvremearandomdate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random l;
        public List<float> temperaturi = new List<float>();
        public List<baraHistogramaVerticala> barile = new List<baraHistogramaVerticala>();
        public List<Label> etichete = new List<Label>();

        public void adaugarandomdate()
        {
           
            for (int i = 0; i < 31; i++)
            {
               

                temperaturi.Add((float)l.Next(-100,100)+101);
                Text = temperaturi.Count.ToString();
                barile.Add(new baraHistogramaVerticala());
                barile[i].Height = (int)temperaturi[i];
                etichete.Add(new Label());
                etichete[i].Text = temperaturi[i].ToString();
                textBox1.Text += i.ToString() + " : " +  temperaturi[i].ToString() + " : " ;
            }
        }

        public void randomnewdatata()
        {

            textBox1.Text += "\r\n";
            for (int i = 0; i < 31; i++)
            {

                Text = temperaturi.Count.ToString();
                temperaturi[i] = (float)l.Next(-100,100)+101;
                barile[i].Height = (int)temperaturi[i];
                etichete[i].Text = temperaturi[i].ToString();

                textBox1.Text += i.ToString() + " : " + temperaturi[i].ToString() + " : ";
            }
            Refresh();
        }

        public void updatbarposition()
        {
            for (int i = 0; i < 31; i++)
            {
                
                barile[i].Left = i * 32;
                barile[i].Top = 200 + barile[i].Height - 100;
                etichete[i].Left = i * 32;
                etichete[i].Top = 30;
                etichete[i].Width = 25;
              
            }
            Refresh();
        }

        public void drawGraficTemperaturiPeVerticala()
        {
            for (int i = 0; i < 31; i++)
            {
                Controls.Add(barile[i]);
                barile[i].Left = i * 32;
                barile[i].Top = 200+barile[i].Height-100;
                barile[i].Show();

                Controls.Add(etichete[i]);
                etichete[i].Left = i * 32;
                etichete[i].Top = 30;
                etichete[i].Width = 25;
                etichete[i].Show();
            }
            Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            l = new Random(100440);
        }

        private void loadRandomTempsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            adaugarandomdate();
        }

        private void drawGraphicOfTemperaturesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawGraficTemperaturiPeVerticala();
        }

        private void loadNewDatasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            randomnewdatata();
            updatbarposition();
        }

        private void updateGraficToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updatbarposition();
        }

        private void updateAllControlsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Controls.Count; i++)
            {
                Controls[i].Invalidate();
            }
        }
    }
}
