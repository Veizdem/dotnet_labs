using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_004
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            base.Text = "Введите пароль";
            
            textBox1.Text = null;
            textBox1.TabIndex = 0;
            textBox1.PasswordChar = '☺';
            textBox1.Font = new Font("Courier New", 12.0F);

            label1.Text = string.Empty;
            label1.Font = new Font("Courier New", 9.0F);

            button1.Text = "Покажи паспорт";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
        }
    }
}
