using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_061
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Text = "Вызвать MatLab";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Type typeMatLab = Type.GetTypeFromProgID("Matlab.Application");

            object matLab = Activator.CreateInstance(typeMatLab);

            object[] commands = new object[] { "x = 0:0.1:6.28; y = sin(x).exp(-x); plot(x,y)" };

            object result = typeMatLab.InvokeMember("Execute", System.Reflection.BindingFlags.InvokeMethod, null, matLab, commands);

        }
    }
}
