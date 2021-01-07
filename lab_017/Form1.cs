using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_017
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            base.Text = "Щелкните на кнопке";

            button1.Click += new EventHandler(this.Cnock);
            button2.Click += new EventHandler(this.Cnock);

            label1.Text = null;
        }

        private void Cnock(object sender, EventArgs e)
        {
            string S = Convert.ToString(sender);

            Button button = (Button)sender;

            label1.Text = "Нажата кнопка " + button.Text;
        }
    }
}
