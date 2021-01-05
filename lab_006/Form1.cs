using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_006
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Text = "Флажок CheckBox";

            checkBox1.Text = "Полужирный";

            checkBox2.Text = "Наклонный";

            label1.Text = "Выбери стиль шрифта";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Font = new Font("Courier New", 14.0F);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Font = new Font("Courier New", 14.0F, label1.Font.Style ^ FontStyle.Bold);

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Font = new Font("Courier New", 14.0F, label1.Font.Style ^ FontStyle.Italic);
        }
    }
}
