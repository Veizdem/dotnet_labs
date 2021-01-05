using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_003
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Text = "Извлечение квадратного корня";
            button1.Text = "Извлечь корень";
            textBox1.Clear();
            label1.Text = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float X;

            bool isNumber = Single.TryParse(textBox1.Text,
                System.Globalization.NumberStyles.Number,
                System.Globalization.NumberFormatInfo.CurrentInfo, out X);

            if (isNumber == false)
            {
                label1.Text = "Следует вводить числа";
                label1.ForeColor = Color.Red;
                return;
            }

            float Y = (float)Math.Sqrt(X);

            label1.ForeColor = Color.Black;
            label1.Text = String.Format("Корень из {0} равен {1:F5}", X, Y);

        }
    }
}
