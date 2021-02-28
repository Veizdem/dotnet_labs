using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_029
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            base.Text = "Успеваемость студента";

            label1.Text = "Номер п/п";
            label2.Text = "Ф.И.О.";
            label3.Text = "Средний балл";

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            button1.Text = "Читать";
            button2.Text = "Сохранить";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"e:\student.usp") == false) return;

            var reader = new BinaryReader(File.OpenRead(@"e:\student.usp"));

            try
            {
                int num = reader.ReadInt32();
                string fio = reader.ReadString();
                float avg = reader.ReadSingle();

                textBox1.Text = Convert.ToString(num);
                textBox2.Text = Convert.ToString(fio);
                textBox3.Text = Convert.ToString(avg);
            }
            finally
            {
                reader.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var writer = new BinaryWriter(File.Open(@"e:\student.usp", FileMode.Create));

            try
            {
                int num = Convert.ToInt32(textBox1.Text);
                string fio = Convert.ToString(textBox2.Text);
                float avg = Convert.ToSingle(textBox3.Text);

                writer.Write(num);
                writer.Write(fio);
                writer.Write(avg);
            }
            finally
            {
                writer.Close();
            }
        }
    }
}
