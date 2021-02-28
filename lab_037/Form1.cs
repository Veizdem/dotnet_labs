using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_037
{
    public partial class Form1 : Form
    {
        string[] month = new string[] { "Янв", "Фев", "Март", "Апр", "Май", "Июнь", "Июль", "Авг", "Сент", "Окт", "Нояб", "Дек" };

        int[] sales = new int[] { 335, 414, 572, 629, 750, 931, 753, 599, 422, 301, 245, 155 };

        Graphics graphics;

        Bitmap bitmap;

        int marLeft = 35;
        int marRight = 15;
        int marTop = 10;
        int marBottom = 20;

        int sizeVert, sizeHor, yHor, xMax, xStart;

        double counterHor, counterVert;

        public Form1()
        {
            InitializeComponent();

            this.Text = "Постоение графика";

            button1.Text = "Нарисовать график";

            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height, pictureBox1.CreateGraphics());

            yHor = pictureBox1.Height - marBottom;

            xMax = pictureBox1.Width - marRight;

            sizeHor = pictureBox1.Width - (marLeft + marRight);

            sizeVert = yHor - marTop;

            counterHor = (double)(sizeHor / sales.Length);
            
            counterVert = (int)(sizeVert / 10);

            xStart = marRight + 30;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            graphics = Graphics.FromImage(bitmap);

            PaintXY();
            PaintHorizontal();
            PaintVertical();
            Paint();

            pictureBox1.Image = bitmap;

            graphics.Dispose();
        }

        private void PaintXY()
        {
            Pen pen = new Pen(Color.Black, 2);

            graphics.DrawLine(pen, marLeft, yHor, marLeft, marTop);

            graphics.DrawLine(pen, marLeft, yHor, xMax, yHor);

            for (int i = 1; i < 10; i++)
            {
                int Y = (int)(yHor - (i * counterVert));

                graphics.DrawLine(pen, marLeft - 5, Y, marLeft, Y);

                graphics.DrawString((i * 100).ToString(), new Font("Arial", 8), Brushes.Black, 2, Y - 5);
            }

            for (int i = 0; i <= month.Length - 1; i++)
            {
                graphics.DrawString(month[i], new Font("Arial", 8), Brushes.Black, marLeft + 10 + (int)(i * counterHor), yHor + 4);

            }
        }

        private void PaintHorizontal()
        {
            Pen pen = new Pen(Color.LightGray, 1);

            for (int i = 1; i <= 10; i++)
            {
                int Y = (int)(yHor - (counterVert * i));

                graphics.DrawLine(pen, marLeft + 3, Y, xMax, Y);

            }

            pen.Dispose();
        }

        private void PaintVertical()
        {
            Pen pen = new Pen(Color.Bisque, 1);

            for (int i = 0; i < month.Length; i++)
            {
                int X = xStart + (int)(counterHor * i);

                graphics.DrawLine(pen, X, marTop, X, yHor - 4);

            }

            pen.Dispose();
        }

        private void Paint()
        {
            double vert = (double)sizeVert / 1000;

            int[] Y = new int[sales.Length];
            int[] X = new int[sales.Length];

            for (int i = 0; i <= sales.Length - 1; i++)
            {
                Y[i] = yHor - (int)(sales[i] * vert);
                X[i] = xStart + (int)(counterHor * i);

            }

            Pen pen = new Pen(Color.Blue, 3);

            graphics.DrawEllipse(pen, X[0] - 2, Y[0] - 2, 4, 4);

            for (int i = 0; i <= sales.Length - 2; i++)
            {
                graphics.DrawLine(pen, X[i], Y[i], X[i + 1], Y[i + 1]);

                graphics.DrawEllipse(pen, X[i + 1] - 2, Y[i + 1] - 2, 4, 4);

            }
        }
    }
}
