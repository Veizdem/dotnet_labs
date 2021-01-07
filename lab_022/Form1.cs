using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_022
{
    public partial class Form1 : Form
    {
        System.Globalization.CultureInfo cultureInfo = System.Globalization.CultureInfo.CurrentCulture;

        string dotOrComa;

        public Form1()
        {
            InitializeComponent();

            this.Text = "Введите число";

            dotOrComa = cultureInfo.NumberFormat.NumberDecimalSeparator;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool isDotOrComaSelect = false;

            if (char.IsDigit(e.KeyChar) == true) return;

            if (e.KeyChar == (char)Keys.Back) return;

            if (textBox1.Text.IndexOf(dotOrComa) != -1)
            {
                isDotOrComaSelect = true;
            }

            if (isDotOrComaSelect == true)
            {
                e.Handled = true;
                return;
            }

            if (e.KeyChar.ToString() == dotOrComa) return;

            e.Handled = true;
        }
    }
}
