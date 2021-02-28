using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_033
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Text = "Выбор графического примитива";

            listBox1.Items.AddRange(new Object[] { "Окружность", "Отрезок", "Прямоугольник", "Сектор", "Текст", "Эллипс", "Закрашенный сектор" });

            Font = new Font("Times New Roman", 14);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();

            Pen pen = new Pen(Color.Red);

            Brush brush = new SolidBrush(Color.Red);

            graphics.Clear(SystemColors.Control);

            switch (listBox1.SelectedIndex)
            {
                case 0:
                    graphics.DrawEllipse(pen, 50, 50, 150, 150);
                    break;
                case 1:
                    graphics.DrawLine(pen, 50, 50, 200, 200);
                    break;
                case 2:
                    graphics.DrawRectangle(pen, 50, 30, 150, 180);
                    break;
                case 3:
                    graphics.DrawPie(pen, 40, 50, 200, 200, 180, 225);
                    break;
                case 4:
                    string s = "Каждый во что-то верит, но\n" +
                        "жизнь преподносит сюрпризы.";
                    graphics.DrawString(s, Font, brush, 10, 100);
                    break;
                case 5:
                    graphics.DrawEllipse(pen, 30, 30, 150, 200);
                    break;
                case 6:
                    graphics.FillPie(brush, 20, 50, 150, 150, 0, 45);
                    break;
            }
        }
    }
}
