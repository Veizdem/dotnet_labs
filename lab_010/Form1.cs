using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_010
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            base.Font = new Font("Times New Roman", 12.0F);
            base.Text = "Греческие буквы";

            button1.Text = "Вычислить";

            label1.Text = string.Format("Найдем длинну окружности:\n" +
                "{0} = 2{1}{2}{1}R,\n" +
                "где {2} = {3}",
                Convert.ToChar(0x3B2), Convert.ToChar(0x2219),
                Convert.ToChar(0x3C0), Math.PI);

            label2.Text = "Введите радиус R:";

            textBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float R;

            bool isNumber = float.TryParse(textBox1.Text,
                System.Globalization.NumberStyles.Number,
                System.Globalization.NumberFormatInfo.CurrentInfo,
                out R);

            if (isNumber == false)
            {
                MessageBox.Show("Следйет вводить числа!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            float beta = 2 * (float)Math.PI * R;

            MessageBox.Show(string.Format("Длина окружности {0} = {1:F4}", Convert.ToChar(0x3B2), beta), "Греческая буква");

        }
    }
}
