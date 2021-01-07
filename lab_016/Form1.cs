using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_016
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Button button1 = new Button();

            button1.Visible = true;
            button1.Size = new Size(100, 30);
            button1.Location = new Point(100, 80);
            button1.Text = "Новая кнопка";
            
            this.Controls.Add(button1);

            button1.Click += Button1_Click;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Нажата новая кнопка");

        }
    }
}
