using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_025
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            textBox1.Multiline = true;
            textBox1.Clear();
            textBox1.Size = new Size(268, 160);

            this.Text = "Простой текстовый редактор";

            openFileDialog1.FileName = @"E:\Text2.txt";
            openFileDialog1.Filter = "Текстовые файлы (*.txt)|*.txt|All files (*.*)|*.*";

            saveFileDialog1.Filter = "Текстовые файлы (*.txt)|*.txt|All files (*.*)|*.*";
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            if (openFileDialog1.FileName == null)
            {
                return;
            }

            try
            {
                var reader = new System.IO.StreamReader
                    (openFileDialog1.FileName,
                    Encoding.GetEncoding(1251));

                textBox1.Text = reader.ReadToEnd();

                reader.Close();

            }
            catch (System.IO.FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message + "\nНет такого файла", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = openFileDialog1.FileName;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) Write();
        }

        void Write()
        {
            try
            {
                var writer = new System.IO.StreamWriter
                    (saveFileDialog1.FileName, false,
                    System.Text.Encoding.GetEncoding(1251));

                writer.Write(textBox1.Text);

                writer.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (textBox1.Modified == false)
            {
                return;
            }

            DialogResult MBox = MessageBox.Show(
                "Текст был изменен.\nСохранить изменения?",
                "Простой редактор",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Exclamation);

            if (MBox == DialogResult.No)
            {
                return;
            }

            if (MBox==DialogResult.Cancel)
            {
                e.Cancel = true;
            }

            if (MBox==DialogResult.Yes)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    Write();
                    return;
                } else
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
