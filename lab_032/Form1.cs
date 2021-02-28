using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_032
{
    public partial class Form1 : Form
    {
        bool isPainting = false;

        public Form1()
        {
            InitializeComponent();

            this.Text = "Рисование мышью в форме";

            button1.Text = "Стереть";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics graphics = CreateGraphics();

            graphics.Clear(SystemColors.Control);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            isPainting = true;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isPainting == true)
            {
                Graphics graphics = CreateGraphics();

                graphics.FillRectangle(new SolidBrush(Color.Red), e.X, e.Y, 10, 10);
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            isPainting = false;
        }
    }
}
