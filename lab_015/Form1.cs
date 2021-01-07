using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_015
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            base.Text = "Мониторинг движения мыши";

        }

        private void listBox1_MouseEnter(object sender, EventArgs e)
        {
            listBox1.Items.Add("Курсор мыши вошел в область ListBox");

        }

        private void listBox1_MouseLeave(object sender, EventArgs e)
        {
            listBox1.Items.Add("Курсор мыши вышел из области ListBox");
        }

        private void listBox1_MouseMove(object sender, MouseEventArgs e)
        {
            textBox1.Text = string.Format("X = {0} или {1}", Form1.MousePosition.X, e.X);
            textBox2.Text = string.Format("Y = {0} или {1}", Form1.MousePosition.Y, e.Y);
        }
    }
}
