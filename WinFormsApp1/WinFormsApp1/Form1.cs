using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            nacrtajPravougaonik(g);
            nacrtajTrapez(g);
            nacrtajProzor1(g);
            nacrtajProzor2(g);
            nacrtajTrougao(g);
            nacrtajVrata(g);
            nacrtajKrov(g);
            nacrtajSteku(g);
            nacrtajMrezuProzora1(g);
            nacrtajMrezuProzora2(g);
            nacrtajSnjeska(g);
        }

        public void nacrtajPravougaonik ( Graphics g)
        {
            Pen olovka = new Pen(Color.Brown);
            olovka.Width = 3f;
            Rectangle pravougaonikKuce = new Rectangle(150, 150, 300, 250);
            g.DrawRectangle(olovka, pravougaonikKuce);
        }

        public void nacrtajSnjeska(Graphics g)
        {
            Pen olovka = new Pen(Color.Black);
            olovka.Width = 3f;
            Pen olovcica = new Pen(Color.Red);
            olovcica.Width = 2f;
            g.DrawEllipse(olovka, 600, 350, 100, 100);
            g.DrawEllipse(olovka, 620, 290, 60, 60);
            g.DrawEllipse(olovka, 633, 255, 35, 35);
            g.DrawLine(olovcica, 625, 305, 605, 285);
            g.DrawLine(olovcica, 675, 305, 695, 285);
        }

        public void nacrtajTrapez ( Graphics g)
        {
            Pen olovka = new Pen(Color.Brown);
            olovka.Width = 3f;
            g.DrawLine(olovka, 100, 150, 500, 150);
            g.DrawLine(olovka, 100, 150, 150, 50);
            g.DrawLine(olovka, 150, 50, 450, 50);
            g.DrawLine(olovka, 450, 50, 500, 150);
        }

        public void nacrtajProzor1 (Graphics g)
        {
            Pen olovka = new Pen(Color.Brown);
            olovka.Width = 3f; 
            Rectangle pravougaonikKuce = new Rectangle(180, 200, 70, 70);
            g.DrawRectangle(olovka, pravougaonikKuce);
        }

        public void nacrtajMrezuProzora1(Graphics g)
        {
            Pen olovka = new Pen(Color.Brown);
            olovka.Width = 2f;
            g.DrawLine(olovka, 180, 235, 250, 235);
            g.DrawLine(olovka, 215, 200, 215, 270);
        }

        public void nacrtajProzor2(Graphics g)
        {
            Pen olovka = new Pen(Color.Brown);
            olovka.Width = 3f;
            Rectangle pravougaonikKuce = new Rectangle(350, 200, 70, 70);
            g.DrawRectangle(olovka, pravougaonikKuce);
        }

        public void nacrtajMrezuProzora2(Graphics g)
        {
            Pen olovka = new Pen(Color.Brown);
            olovka.Width = 2f;
            g.DrawLine(olovka, 385, 200, 385, 272);
            g.DrawLine(olovka, 350, 235, 420, 235);
           
        }

        public void nacrtajTrougao(Graphics g)
        {
            Pen olovka = new Pen(Color.Brown);
            olovka.Width = 7f;
            g.DrawLine(olovka, 215, 150, 375, 150);
            g.DrawLine(olovka, 215, 150, 295, 25);
            g.DrawLine(olovka, 375, 150, 295, 25);
        }

        public void nacrtajVrata(Graphics g)
        {
            Pen olovka = new Pen(Color.Brown);
            olovka.Width = 3f;
            Rectangle vrataKuce = new Rectangle(263, 287, 70, 113);
            g.DrawRectangle(olovka, vrataKuce);
        }

        public void nacrtajKrov(Graphics g)
        {
            Pen olovka = new Pen(Color.Brown);
            olovka.Width = 3f;
            g.DrawLine(olovka, 114, 120, 487, 120);
            g.DrawLine(olovka, 134, 80, 467, 80);

        }

        public void nacrtajSteku(Graphics g)
        {
            Pen olovka = new Pen(Color.Brown);
            olovka.Width = 3f;
            g.DrawEllipse(olovka, 270, 350, 15, 15);
        }

    }
}
