using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_007
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            TabPage tabPage3 = new TabPage
            {
                UseVisualStyleBackColor = true
            };

            this.tabControl1.Controls.Add(tabPage3);

            RadioButton radioButton5 = new RadioButton();
            RadioButton radioButton6 = new RadioButton();

            radioButton5.CheckedChanged += new EventHandler(radioButton5_CheckedChanged);
            radioButton6.CheckedChanged += new EventHandler(radioButton6_CheckedChanged);

            tabPage3.Controls.Add(radioButton5);
            tabPage3.Controls.Add(radioButton6);

            radioButton5.Location = new Point(20, 15);
            radioButton6.Location = new Point(20, 58);

            this.Text = "Какая улыбка Вам ближе";

            tabControl1.TabPages[0].Text = "Текст";
            tabControl1.TabPages[1].Text = "Цвет";
            tabControl1.TabPages[2].Text = "Размер";

            radioButton1.Text = "Восхищенная, сочуственная,\nскромно-смущенная";
            radioButton2.Text = "Нежная улыбка, ехидная, бес" +
                "стыжая, \nподленькая, снисходительная";

            radioButton3.Text = "Красный";
            radioButton4.Text = "Синий";

            radioButton5.Text = "9 пунктов";
            radioButton6.Text = "13 пунктов";

            label1.Text = radioButton1.Text;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = radioButton1.Text;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = radioButton2.Text;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Blue;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font.Name, 9.0F);
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font.Name, 13.0F);
        }
    }
}
