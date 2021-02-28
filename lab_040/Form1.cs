using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace lab_040
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        extern static void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

        public Form1()
        {
            InitializeComponent();

            button1.Text = "Microsoft API";
            button2.Text = "SendKeys";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            keybd_event(44, 1, 0, 0);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SendKeys.Send("%{PRTSC}");

        }
    }
}
