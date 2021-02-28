using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_034
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string[] allColors = Enum.GetNames(typeof(KnownColor));

            listBox1.Items.Clear();
            listBox1.Items.AddRange(allColors);
            listBox1.Sorted = true;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.Text == "Transparent") return;
            this.BackColor = Color.FromName(listBox1.Text);
            this.Text = "Цвет: " + listBox1.Text;
        }
    }
}
