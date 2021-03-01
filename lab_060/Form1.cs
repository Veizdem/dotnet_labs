using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_060
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            AutoCAD.AcadApplication ACAD1 = new AutoCAD.AcadApplication();
            AutoCAD.AcadDocuments Docs1 = ACAD1.Documents;
            AutoCAD.AcadDocument Doc1 = Docs1.Add();

            ACAD1.Visible = true;

            double[] T1 = { 10, 10, 0 };
            double[] T2 = { 200, 200, 0 };
            double[] T3 = { 200, 10, 0 };
            double[] T4 = { 15, 200, 0 };

            Doc1.ModelSpace.Addline(T1, T2);

            Doc1.ModelSpace.Addline(T2, T3).Color = AutoCAD.ACAD_COLOR.acRed;

            Doc1.ModelSpace.AddText("Горизонтальный", T4, 22);

            Doc1.ModelSpace.AddText("Вертикальный", T1, 22).Rotation = Math.PI / 2;

            Doc1.SaveAs(@"e:\draw.dwg");

            ACAD1.Quit();
        }
    }
}
