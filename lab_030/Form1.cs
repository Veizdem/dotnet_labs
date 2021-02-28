using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_030
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            base.Text = "Рисунок";
            
            this.Width = 200;
            this.Height = 200;

            Image img = new Bitmap("e:/img.jpg");

            e.Graphics.DrawImage(img, 5, 5);

        }
    }
}
