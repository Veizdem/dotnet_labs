using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_045
{
    public partial class Form1 : Form
    {
        System.IO.StringReader reader;

        public Form1()
        {
            InitializeComponent();

            this.Text = "Формирование таблицы";

            double[] X = { 5342736.17653, 2345.3333, 234683.853749, 2438454.825368, 3425.72564, 5243.25, 537407.6236, 6354328.9876, 5342.243 };

            double[] Y = { 27488.17, 3806703.356, 22345.72, 54285.34, 2236767.3267, 57038.76, 201722.3, 26434.001, 2164.022 };

            textBox1.Multiline = true;
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Font = new Font("Courier New", 9.0F);
            textBox1.Text = "КАТАЛОГ КООРДИНАТ\r\n";
            textBox1.Text += "---------------------------------\r\n";
            textBox1.Text += "|Пункт|     X      |     Y      |\r\n";
            textBox1.Text += "---------------------------------\r\n";

            for (int i = 0; i <= 8; i++)
            {
                textBox1.Text += string.Format("| {0,3:D} | {1,10:F2} | {2,10:F2} |", i, X[i], Y[i]) + "\r\n";
            }
            textBox1.Text += "---------------------------------\r\n";
        }

        private void печатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                reader = new System.IO.StringReader(textBox1.Text);

                try
                {
                    printDocument1.Print();
                }
                finally
                {
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
