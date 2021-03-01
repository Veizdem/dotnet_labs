using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_056
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var xl = new Microsoft.Office.Interop.Excel.Application();

            double PI = xl.WorksheetFunction.Pi();

            this.Text = "PI = " + PI;
        }
    }
}
