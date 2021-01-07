using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_018
{
    public partial class Form1 : Form
    {
        string znak = null;
        bool startEdit = true;
        double number1, number2;

        public Form1()
        {
            InitializeComponent();

            this.Text = "Калькулятор";

            button1.Text = "1";
            button2.Text = "2";
            button3.Text = "3";
            button4.Text = "4";
            button5.Text = "5";
            button6.Text = "6";
            button7.Text = "7";
            button8.Text = "8";
            button9.Text = "9";
            button10.Text = "0";

            button11.Text = "=";
            button12.Text = "+";
            button13.Text = "-";
            button14.Text = "*";
            button15.Text = "/";
            button16.Text = "Очистить";

            textBox1.Text = "0";
            textBox1.TextAlign = HorizontalAlignment.Right;

            this.button1.Click += new System.EventHandler(this.Digit);
            this.button2.Click += new System.EventHandler(this.Digit);
            this.button3.Click += new System.EventHandler(this.Digit);
            this.button4.Click += new System.EventHandler(this.Digit);
            this.button5.Click += new System.EventHandler(this.Digit);
            this.button6.Click += new System.EventHandler(this.Digit);
            this.button7.Click += new System.EventHandler(this.Digit);
            this.button8.Click += new System.EventHandler(this.Digit);
            this.button9.Click += new System.EventHandler(this.Digit);
            this.button10.Click += new System.EventHandler(this.Digit);

            this.button12.Click += new System.EventHandler(this.Operation);
            this.button13.Click += new System.EventHandler(this.Operation);
            this.button14.Click += new System.EventHandler(this.Operation);
            this.button15.Click += new System.EventHandler(this.Operation);

            this.button11.Click += new System.EventHandler(this.Equal);

            this.button16.Click += new System.EventHandler(this.Clear);
        }

        private void Digit(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            string digit = button.Text;

            if (startEdit == true)
            {
                textBox1.Text = digit;
                startEdit = false;
                return;
            } else
            {
                textBox1.Text = textBox1.Text + digit;
            }
        }

        private void Operation(object sender, EventArgs e)
        {
            number1 = double.Parse(textBox1.Text);

            Button button = (Button)sender;

            znak = button.Text;

            startEdit = true;
        }

        private void Equal(object sender, EventArgs e)
        {
            double result = 0;

            number2 = double.Parse(textBox1.Text);

            switch (znak)
            {
                case "+":
                    result = number1 + number2;
                    break;
                case "-":
                    result = number1 - number2;
                    break;
                case "*":
                    result = number1 * number2;
                    break;
                case "/":
                    result = number1 / number2;
                    break;
            }

            znak = null;

            textBox1.Text = result.ToString();

            number1 = result;

            startEdit = true;
        }

        private void Clear(object sender, EventArgs e)
        {
            textBox1.Text = "0";

            znak = null;

            startEdit = true;
        }
    }
}
