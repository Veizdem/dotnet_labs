using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_044
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            textBox1.Multiline = true;
            textBox1.Size = new Size(320, 216);

            this.Text = "Формирование таблицы";

            string[] names = { "Андрей - раб", "Света-Х", "ЖЭК", "Справка по тел", "Александр Степанович", "Мама - дом", "Карапузова Таня", "Погода сегодня", "Театр Браво" };

            string[] phones = { "274-88-14", "+38(067)7030356", "22-345-72", "009", "223-67-67 доп 32-67", "570-38-76", "201-72-23-прямой моб", "001", "216-40-22" };

            textBox1.ScrollBars = ScrollBars.Vertical;

            textBox1.Font = new Font("Courier New", 9.0F);

            textBox1.Text = "ТАБЛИЦА ТЕЛЕФОНОВ\r\n\r\n";

            for (int i = 0; i <= 8; i++)
            {
                textBox1.Text += String.Format("{0, -21} {1, -21}", names[i], phones[i]) + "\r\n";

            }

            textBox1.Text += "\r\nПРИМЕЧАНИЕ:" +
                "\r\nдля корректного отображения таблицы" +
                "\r\nв Блокноте укажите шрифт Courier New";

            var writer = new System.IO.StreamWriter(@"e:\Table_CS.txt", false, System.Text.Encoding.GetEncoding(1251));

            writer.Write(textBox1.Text);
            writer.Close();
        }

        private void показатьТаблицуВБлокнотеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("Notepad", @"e:\Table_CS.txt");

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
    }
}
