using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_020
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            base.Font = new Font(FontFamily.GenericMonospace, 14.0F);
            base.Text = "Какие клавиши нажаты сейчас:";

            label1.Text = string.Empty;
            label2.Text = string.Empty;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            label2.Text = string.Empty;

            if (e.Alt == true)
            {
                label2.Text += "Alt: Yes\n";
            } else
            {
                label2.Text += "Alt: No\n";
            }

            if (e.Shift == true)
            {
                label2.Text += "Shift: Yes\n";
            }
            else
            {
                label2.Text += "Shift: No\n";
            }

            if (e.Control == true)
            {
                label2.Text += "Control: Yes\n";
            }
            else
            {
                label2.Text += "Control: No\n";
            }

            label2.Text += "Код клавиши: " + e.KeyCode +
                "\nKeyData: " + e.KeyData +
                "\nKeyValue: " + e.KeyValue;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            label1.Text = "Нажата клавиша: " + e.KeyChar;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            label1.Text = string.Empty;
            label1.Text = string.Empty;
        }
    }
}
