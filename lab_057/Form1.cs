using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_057
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            label1.Text = "Год. ставка в %";
            label2.Text = "Срок в месяцах";
            label3.Text = "Размер кредита";

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            this.Text = "Расчет платежей";
            button1.Text = "Расчет";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var XL = new Microsoft.Office.Interop.Excel.Application();

                double pay = XL.WorksheetFunction.Pmt((Convert.ToDouble(textBox1.Text)) / 1200, Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text));

                string ss = string.Format("Каждый месяц следует платить {0:$#.##} долларов", Math.Abs(pay));

                MessageBox.Show(ss);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
