using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_027
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            base.Text = "Простой RTF-редактор";
            richTextBox1.Clear();
            openFileDialog1.FileName = @"e:\Text2.txt";
            saveFileDialog1.Filter = "Файлы RTF (*.RTF) |*.RTF";

            this.открытьВФорматеRTFToolStripMenuItem.Click += new System.EventHandler(this.Open);
            this.открытьВФорматеWindows1251ToolStripMenuItem.Click += new System.EventHandler(this.Open);
        }

        private void Open(object sender, EventArgs e)
        {
            ToolStripMenuItem t = (ToolStripMenuItem)sender;
            string format = t.Text;

            try
            {
                if (format=="Открыть в формате RTF")
                {
                    openFileDialog1.Filter = "Файлы RTF (*.RTF) |*.RTF";
                    openFileDialog1.ShowDialog();

                    if (openFileDialog1.FileName == null) return;

                    richTextBox1.LoadFile(openFileDialog1.FileName);
                }

                if (format == "Открыть в формате Windows 1251")
                {
                    openFileDialog1.Filter = "Текстовые файлы (*.txt) |*.txt";
                    openFileDialog1.ShowDialog();

                    if (openFileDialog1.FileName == null) return;

                    richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                }

                richTextBox1.Modified = false;
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

        private void сохранитьВФорматеRTFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = openFileDialog1.FileName;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK) Write();
        }

        void Write()
        {
            try
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName);
                richTextBox1.Modified = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (richTextBox1.Modified == false) return;

            DialogResult MBox = MessageBox.Show("Текст был изменент. \nСохранить изменения?", "Простой редактор", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);

            if (MBox == DialogResult.No) return;

            if (MBox == DialogResult.Cancel) e.Cancel = true;

            if (MBox == DialogResult.Yes)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    Write();
                    return;
                }
                else e.Cancel = true;
            }
        }
    }
}
