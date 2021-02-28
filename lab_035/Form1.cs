using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_035
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Pen pen = new Pen(Color.Red);

            e.Graphics.DrawEllipse(pen, 50, 50, 150, 150);
        }
    }
}
