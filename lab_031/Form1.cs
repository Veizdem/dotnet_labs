using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_031
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            pictureBox1.Image = Image.FromFile(@"e:\img.jpg");

            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;

            panel1.AutoScroll = true;

            this.Text = "Скроллинг";
        }
    }
}
