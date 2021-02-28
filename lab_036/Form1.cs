using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_036
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Text = @"Печать файла E:\img.bmp";

            button1.Text = "Печать";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                printDocument1.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка печати на принтере\n", ex.Message);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(Image.FromFile(@"E:\img.bmp"), e.Graphics.VisibleClipBounds);

            e.HasMorePages = false;
        }
    }
}
