using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_009
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            comboBox1.Text = "Выбери опцию";
            comboBox1.Items.AddRange(new string[]
            {
                "Прибавить",
                "Отнять",
                "Умножить",
                "Разделить",
                "Очистить"
            });
            comboBox1.TabIndex = 2;

            textBox1.Clear();
            textBox1.TabIndex = 0;

            textBox2.Clear();
            textBox2.TabIndex = 1;

            this.Text = "Суперкалькулятор";

            label1.Text = "Равно: ";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = "Равно: ";

            float X, Y, Z = 0;

            bool isNumber1 = float.TryParse(textBox1.Text,
                System.Globalization.NumberStyles.Number,
                System.Globalization.NumberFormatInfo.CurrentInfo,
                out X);

            bool isNumber2 = float.TryParse(textBox2.Text,
                System.Globalization.NumberStyles.Number,
                System.Globalization.NumberFormatInfo.CurrentInfo,
                out Y);

            if (isNumber1 == false || isNumber2 == false)
            {
                MessageBox.Show("Следует вводить числа!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    Z = X + Y;
                    break;
                case 1:
                    Z = X - Y;
                    break;
                case 2:
                    Z = X * Y;
                    break;
                case 3:
                    Z = X / Y;
                    break;
                case 4:
                    textBox1.Clear();
                    textBox2.Clear();
                    label1.Text = "Равно: ";
                    return;
                default:
                    break;
            }

            label1.Text = string.Format("Равно: {0:F5}", Z);

        }
    }
}
