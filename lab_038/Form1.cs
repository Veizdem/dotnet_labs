using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_038
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Text = "Введите текст в верхнее поле";

            textBox1.Clear();
            textBox2.Clear();

            textBox1.TabIndex = 0;

            button1.Text = "Записать в БО";
            button2.Text = "Извлечь из БО";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != String.Empty)
            {
                Clipboard.SetDataObject(textBox1.SelectedText);
                textBox2.Text = String.Empty;
            } else
            {
                textBox2.Text = "В верхнем поле текст не выделен";

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IDataObject data = Clipboard.GetDataObject();

            if (data.GetDataPresent(DataFormats.Text) == true)
            {
                textBox2.Text = data.GetData(DataFormats.Text).ToString();

            } else
            {
                textBox2.Text = "Запишите что-либо в буфер обмена";

            }
        }
    }
}
