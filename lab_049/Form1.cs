using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_049
{
    public partial class Form1 : Form
    {
        int n;

        DataTable dt = new DataTable();

        public Form1()
        {
            InitializeComponent();

            base.Text = "Решение системы уравнений";

            textBox1.TabIndex = 0;

            dataGridView1.Visible = false;

            label1.Text = "Введите количество неизвестных:";

            button1.Text = "Ввести";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[,] A = new double[n, n];
            double[] L = new double[n];

            bool isNumber = false;

            int i, j;

            string tmp;

            if (button1.Text == "Ввести")
            {
                for (;;)
                {
                    isNumber = int.TryParse(textBox1.Text, System.Globalization.NumberStyles.Integer, System.Globalization.NumberFormatInfo.CurrentInfo, out n);

                    if (isNumber == false)
                    {
                        return;
                    }

                    button1.Text = "Решить";

                    textBox1.Enabled = false;

                    dataGridView1.Visible = true;
                    dataGridView1.DataSource = dt;

                    for (i = 0; i < n; i++)
                    {
                        tmp = "X" + Convert.ToString(i);
                        dt.Columns.Add(new DataColumn(tmp));

                    }

                    dt.Columns.Add(new DataColumn("L"));
                    return;
                }
            }
            else
            {
                if (dt.Rows.Count != n)
                {
                    MessageBox.Show("Количество строк не равно количеству колонок");
                    return;
                }

                for (j = 0; j < n; j++)
                {
                    for (i = 0; i < n; i++)
                    {
                        A[j, i] = retNum(j, i, ref isNumber);
                        if (isNumber == false) return;
                    }

                    L[j] = retNum(j, i, ref isNumber);
                    if (isNumber == false) return;
                }
            }

            gauss(n, A, ref L);

            string s = "Неизвестные равны:\n";
            for (j = 0; j < n; j++)
            {
                tmp = L[j].ToString();
                s += "X" + (j + 1).ToString() + " = " + tmp + ";\n";

            }

            MessageBox.Show(s);
        }

        private double retNum(int j, int i, ref bool isNumber)
        {
            double work;

            string tmp = dt.Rows[j][i].ToString();

            isNumber = double.TryParse(tmp, System.Globalization.NumberStyles.Number, System.Globalization.NumberFormatInfo.CurrentInfo, out work);

            if (isNumber == false)
            {
                tmp = string.Format("Номер строки {0}, номер столбца {1},\n" +
                    "в данном полне - не число", j + 1, i + 1);
                MessageBox.Show(tmp);
            }

            return work;
        }

        private void gauss(int n, double[,] A, ref double[] LL)
        {
            int i, j, l = 0;

            double c1, c2, c3;

            for (i = 0; i < n; i++)
            {
                c1 = 0;

                for (j = i; j < n; j++)
                {
                    c2 = A[j, i];

                    if (Math.Abs(c2) > Math.Abs(c1))
                    {
                        l = j;
                        c1 = c2;
                    }
                }

                for (j = i; j < n; j++)
                {
                    c3 = A[l, j] / c1;
                    A[l, j] = A[i, j];
                    A[i, j] = c3;
                }

                c3 = LL[l] / c1;
                LL[l] = LL[i];
                LL[i] = c3;

                for (j = 0; j < n; j++)
                {
                    if (j == i) continue;

                    for (l = i + 1; l <= n - 1; l++)
                    {
                        A[j, l] = A[j, l] - A[i, l] * A[j, i];

                    }

                    LL[j] = LL[j] - LL[i] * A[j, i];
                                            
                }
            }
        }
    }
}
