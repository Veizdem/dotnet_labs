using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using XL = Microsoft.Office.Interop.Excel;

namespace lab_059
{
    class Program
    {
        static void Main(string[] args)
        {
            XL.Application xl = new XL.Application();
            xl.Workbooks.Add();

            xl.ActiveSheet.Range["A2"].Value = "Март";
            xl.ActiveSheet.Range["A3"].Value = "Апр";
            xl.ActiveSheet.Range["A4"].Value = "Май";
            xl.ActiveSheet.Range["A5"].Value = "Июнь";
            xl.ActiveSheet.Range["A6"].Value = "Июль";
            xl.ActiveSheet.Range["B2"].Value = 138;
            xl.ActiveSheet.Range["B3"].Value = 85;
            xl.ActiveSheet.Range["B4"].Value = 107;
            xl.ActiveSheet.Range["B5"].Value = 56;
            xl.ActiveSheet.Range["B6"].Value = 34;

            xl.Charts.Add();

            xl.ActiveChart.ChartType = XL.XlChartType.xlColumnClustered;

            xl.ActiveChart.HasLegend = false;

            xl.ActiveChart.HasTitle = true;

            xl.ActiveChart.ChartTitle.Characters.Text = "ПРОДАЖИ ЗА ПЯТЬ МЕСЯЦЕВ";

            xl.ActiveChart.Axes(XL.XlAxisType.xlValue).HasTitle = true;
            xl.ActiveChart.Axes(XL.XlAxisType.xlValue).AxisTitle.Characters.Text = "Уровни продаж";

            xl.ActiveChart.Axes(XL.XlAxisType.xlCategory).HasTitle = true;
            xl.ActiveChart.Axes(XL.XlAxisType.xlCategory).AxisTitle.Characters.Text = "Месяцы";

            xl.ActiveChart.Export(@"e:\excel_graph.jpg");

            xl.Visible = true;
        }
    }
}
