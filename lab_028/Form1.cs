using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_028
{
    public partial class Form1 : Form
    {
        System.IO.StreamReader reader;

        public Form1()
        {
            InitializeComponent();
            
            base.Text = "Открытие текстового файла и его печать";

            textBox1.Multiline = true;
            textBox1.Clear();
            textBox1.Size = new System.Drawing.Size(268, 112);
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.ReadOnly = true;

            печатьToolStripMenuItem.Visible = false;

            openFileDialog1.FileName = null;
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Текстовые файлы (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.ShowDialog();

            if (openFileDialog1.FileName == null) return;

            try
            {
                reader = new System.IO.StreamReader(openFileDialog1.FileName, System.Text.Encoding.GetEncoding(1251));

                textBox1.Text = reader.ReadToEnd();

                reader.Close();

                печатьToolStripMenuItem.Visible = true;
            }
            catch (System.IO.FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message + "\nНет такого файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void печатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                reader = new System.IO.StreamReader(openFileDialog1.FileName, System.Text.Encoding.GetEncoding(1251));

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
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float linesPerPage = 0;
            float yPos = 0;
            int count = 0;
            float leftMargin = e.MarginBounds.Left;
            float topMargin = e.MarginBounds.Top;
            string line = null;

            Font printFont = new Font("Times New Roman", 12.0F);

            linesPerPage = e.MarginBounds.Height / printFont.GetHeight(e.Graphics);

            while (count < linesPerPage)
            {
                line = reader.ReadLine();

                if (line == null) break;

                yPos = topMargin + count * printFont.GetHeight(e.Graphics);

                e.Graphics.DrawString(line, printFont, Brushes.Black, leftMargin, yPos, new StringFormat());

                count += 1;
            }

            if (line != null) { e.HasMorePages = true; }
            else { e.HasMorePages = false; }
        }
    }
}
