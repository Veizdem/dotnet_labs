﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_008
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Text = "Житейская мудрость";

            label1.Text = "Сколько ребенка не учи хорошим манерам, \n" +
                "он будет поступать так, как папа с мамой.";
            label1.TextAlign = ContentAlignment.MiddleCenter;

            button1.Text = "Кнопка";

            toolTip1.SetToolTip(button1, "Кнопка\r\nсчастья");
            toolTip1.IsBalloon = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = !label1.Visible;
        }
    }
}
