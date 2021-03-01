using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_062
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Text = "Решить СЛАУ";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Type typeMatLab = Type.GetTypeFromProgID("Matlab.Application");

            object matLab = Activator.CreateInstance(typeMatLab);

            object[] commands = new object[] { "A = [ 1 1 1; 1 1 0; 0 1 1 ]; L = [6; 3; 5]; " +
                "X = inv(A)*l % обратная матрица inv" };

            object result = typeMatLab.InvokeMember("Execute", BindingFlags.InvokeMethod, null, matLab, commands);

            var p = new ParameterModifier(4);

            p[0] = false; p[1] = false; p[2] = true; p[3] = true;

            ParameterModifier[] mods = { p };

            double[,] X = new double[3, 1];

            object[] arg = new object[] { "X", "base", X, new double[0] };

            result = typeMatLab.InvokeMember("GetFullMatrix", BindingFlags.InvokeMethod, null, matLab, arg, mods, null, null);

            X = (double[,])arg[2];

            string s = string.Format("x1 = {1}; x2 = {1}; x3 = {2}", X[0, 0], X[1, 0], X[2, 0]);

            MessageBox.Show(s);
        }
    }
}
