using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_024
{
    public partial class Form1 : Form
    {
        string filename = @"C:\Text2.txt";

        public Form1()
        {
            InitializeComponent();

            textBox1.Multiline = true;
            textBox1.Clear();
            textBox1.Size = new Size(268, 112);

            button1.Text = "Открыть";
            button1.TabIndex = 0;

            button2.Text = "Сохранить";

            this.Text = "Здесь кодировка Windows 1251";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var charset = System.Text.Encoding.GetEncoding(1251);

                var reader = new System.IO.StreamReader(filename, charset);

                textBox1.Text = reader.ReadToEnd();

                reader.Close();
            }
            catch (System.IO.FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message + "\nНет такого файла",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var charset = System.Text.Encoding.GetEncoding(1251);

                var writer = new System.IO.StreamWriter(filename, false, charset);

                writer.Write(textBox1.Text);
                writer.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
