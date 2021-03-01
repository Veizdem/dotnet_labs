using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using XL = Microsoft.Office.Interop.Excel.Application;

namespace lab_058
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            double[,] A = { { 1, 1, 1 }, { 1, 1, 0 }, { 0, 1, 1 } };

            double[] L = { 6, 3, 5 };

            XL xl = new XL();

            double detA = xl.Application.WorksheetFunction.MDeterm(A);

            if (Math.Abs(detA) < 0.01)
            {
                label1.Text = "Система не имеет решений,\nпределитель равен нулю.";
                return;
            }

            Object oA = xl.Application.WorksheetFunction.MInverse(A);

            Object[,] X = xl.Application.WorksheetFunction.MMult(oA, xl.Application.WorksheetFunction.Transpose(L));

            label1.Text = string.Format("Неизвестные равны:\n\nx1 = {0}; x2 = {1}, x3 = {2}.", X[1, 1], X[2, 1], X[3, 1]);
        }
    }
}
