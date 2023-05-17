using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1Teoria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int num1, num2, num3, num4, num5, num6, num7, num8, num9, num10;

        private void button1_Click(object sender, EventArgs e)
        {
            numeroAleatorio();
            graficar();
            lecturaNumeros();
        }

        private void numeroAleatorio()
        {
            Random ramdom = new Random();
            int numeroAleatorio1 = ramdom.Next(0, 2);
            int numeroAleatorio2 = ramdom.Next(0, 2);
            int numeroAleatorio3 = ramdom.Next(0, 2);
            int numeroAleatorio4 = ramdom.Next(0, 2);
            int numeroAleatorio5 = ramdom.Next(0, 2);
            int numeroAleatorio6 = ramdom.Next(0, 2);
            int numeroAleatorio7 = ramdom.Next(0, 2);
            int numeroAleatorio8 = ramdom.Next(0, 2);
            int numeroAleatorio9 = ramdom.Next(0, 2);
            int numeroAleatorio10 = ramdom.Next(0, 2);
            txt1.Text = numeroAleatorio1.ToString();
            txt2.Text = numeroAleatorio2.ToString();
            txt3.Text = numeroAleatorio3.ToString();
            txt4.Text = numeroAleatorio4.ToString();
            txt5.Text = numeroAleatorio5.ToString();
            txt6.Text = numeroAleatorio6.ToString();
            txt7.Text = numeroAleatorio7.ToString();
            txt8.Text = numeroAleatorio8.ToString();
            txt9.Text = numeroAleatorio9.ToString();
            txt10.Text = numeroAleatorio10.ToString();
        }

        private void graficar()
        {
            Graphics papel;
            papel = pictureBox1.CreateGraphics();
            Pen lapiz = new Pen(Color.Black);
            Pen lapiz2 = new Pen(Color.Red,5);
            Pen lapiz3 = new Pen(Color.Red, 5);
            Pen lapiz4 = new Pen(Color.Red, 5);
            Pen lapiz5 = new Pen(Color.Red, 5);
            Pen lapiz6 = new Pen(Color.Red, 5);
            Pen lapiz7 = new Pen(Color.Red, 5);
            Pen lapiz8 = new Pen(Color.Red, 5);
            Pen lapiz9 = new Pen(Color.Red, 5);
            Pen lapiz10 = new Pen(Color.Red, 5);
            float xm, ym;
            xm = pictureBox1.Width / 2;
            ym = pictureBox1.Height / 2;

            papel.TranslateTransform(xm, ym);
            papel.DrawLine(lapiz, -xm, 0, xm, 0);
            papel.DrawLine(lapiz, -xm, -ym/2, xm, -ym/2);
            papel.DrawLine(lapiz, -xm, ym / 2, xm, ym / 2);
            papel.DrawLine(lapiz, 0, -ym, 0, ym);
            papel.DrawLine(lapiz, -52, -ym, -52, ym);
            papel.DrawLine(lapiz, -104, -ym, -104, ym);
            papel.DrawLine(lapiz, -156, -ym, -156, ym);
            papel.DrawLine(lapiz, -208, -ym, -208, ym);
            papel.DrawLine(lapiz, -260, -ym, -260, ym);
            papel.DrawLine(lapiz, 52, -ym, 52, ym);
            papel.DrawLine(lapiz, 104, -ym, 104, ym);
            papel.DrawLine(lapiz, 156, -ym, 156, ym);
            papel.DrawLine(lapiz, 208, -ym, 208, ym);
            papel.DrawLine(lapiz, 260, -ym, 260, ym);

            if (num1 != 0)
            {
                papel.DrawLine(lapiz2, -260, 58, -208, 58);
            }
            else 
            {
                papel.DrawLine(lapiz2, -260, -58, -208, -58);
            }
            if (num2 != 0)
            {
                papel.DrawLine(lapiz3, -208, 58, -156, 58);
            }
            else
            {
                papel.DrawLine(lapiz3, -208, -58, -156, -58);
            }
            if (num3 != 0)
            {
                papel.DrawLine(lapiz4, -156, 58, -104, 58);
            }
            else
            {
                papel.DrawLine(lapiz4, -156, -58, -104, -58);
            }
            if (num4 == 1)
            {
                papel.DrawLine(lapiz5, -104, 58, -52, 58);
            }
            else
            {
                papel.DrawLine(lapiz5, -104, -58, -52, -58);
            }
            if (num5 == 1)
            {
                papel.DrawLine(lapiz6, -52, 58, 0, 58);
            }
            else
            {
                papel.DrawLine(lapiz6, -52, -58, 0, -58);
            }
            //if (num6 == 1)
            //{
            //    papel.DrawLine(lapiz2, 0, 58, 52, 58);
            //}
            //else
            //{
            //    papel.DrawLine(lapiz2, 0, -58, 52, -58);
            //}
            //if (num7 == 1)
            //{
            //    papel.DrawLine(lapiz2, 52, 58, 104, 58);
            //}
            //else
            //{
            //    papel.DrawLine(lapiz2, 52, -58, 104, -58);
            //}
            //if (num8 == 1)
            //{
            //    papel.DrawLine(lapiz2, 104, 58, 156, 58);
            //}
            //else
            //{
            //    papel.DrawLine(lapiz2, 104, -58, 156, -58);
            //}
            //if (num9 == 1)
            //{
            //    papel.DrawLine(lapiz2, 156, 58, 208, 58);
            //}
            //else
            //{
            //    papel.DrawLine(lapiz2, 156, -58, 208, -58);
            //}
            //if (num10 == 1)
            //{
            //    papel.DrawLine(lapiz2, 208, 58, 260, 58);
            //}
            //else
            //{
            //    papel.DrawLine(lapiz2, 208, -58, 260, -58);
            //}

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            graficar();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lecturaNumeros()
        {
            num1 = Convert.ToInt16(txt1.Text);
            num2 = Convert.ToInt16(txt2.Text);
            num3 = Convert.ToInt16(txt3.Text);
            num4 = Convert.ToInt16(txt4.Text);
            num5 = Convert.ToInt16(txt5.Text);
            num6 = Convert.ToInt16(txt6.Text);
            num7 = Convert.ToInt16(txt7.Text);
            num8 = Convert.ToInt16(txt8.Text);
            num9 = Convert.ToInt16(txt9.Text);
            num10 = Convert.ToInt16(txt10.Text);
        }
    }
}
